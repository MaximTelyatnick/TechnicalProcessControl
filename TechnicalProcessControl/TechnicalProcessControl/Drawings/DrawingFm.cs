using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;
using TechnicalProcessControl.BLL.ModelsDTO;

namespace TechnicalProcessControl.Drawings
{
    public partial class DrawingFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public IDrawingService drawingService;
        public BindingSource drawingBS = new BindingSource();

        private UsersDTO usersDTO;

        public DrawingFm(UsersDTO usersDTO)
        {
            InitializeComponent();

            this.usersDTO = usersDTO;

            splashScreenManager.ShowWaitForm();
            LoadData();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            drawingService = Program.kernel.Get<IDrawingService>();

            drawingBS.DataSource = drawingService.GetAllDrawing();
            drawingTreeListGrid.DataSource = drawingBS;
            drawingTreeListGrid.KeyFieldName = "Id";
            drawingTreeListGrid.ParentFieldName = "ParentId";
            drawingTreeListGrid.ExpandAll();
        }

        public void EditDrawing(Utils.Operation operation, DrawingDTO drawingDTO)
        {
            //List<DrawingScanDTO> drawingScanList = drawingService.GetDravingScanById(); 

            using (DrawingEditFm drawingEditFm = new DrawingEditFm(usersDTO,drawingDTO, operation))
            {
                if (drawingEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DrawingDTO return_Id = drawingEditFm.Return();
                    drawingGridView.BeginUpdate();
                    LoadData();
                    drawingGridView.EndUpdate();
                    int rowHandle = drawingGridView.LocateByValue("Id", return_Id.Id);
                    drawingGridView.FocusedRowHandle = rowHandle;

                }
                else
                {
                    drawingGridView.BeginUpdate();
                    LoadData();
                    drawingGridView.EndUpdate();

                }
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((DrawingDTO)drawingBS.Current).ParentId != null)
            {
                MessageBox.Show("Нельзя удалить старую версию чертежа", "Підтвердження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Удалить чертеж?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                drawingService = Program.kernel.Get<IDrawingService>();

                if (drawingService.CheckDrawingContainAnyTechProcess(((DrawingDTO)drawingBS.Current).Id))
                {
                    if (MessageBox.Show("Чертеж содержит техпроцессы, при удалении чертежа будут удалены и техпроцессы!", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }
                

                splashScreenManager.ShowWaitForm();

                drawingGridView.PostEditor();
                drawingGridView.BeginUpdate();

                if (drawingService.DrawingDelete(((DrawingDTO)drawingBS.Current).Id))
                {
                    if (drawingService.GetDrawingChildByParentId(((DrawingDTO)drawingBS.Current).Id) != null)
                    {
                        DrawingDTO updateDrawing = drawingService.GetDrawingChildByParentId(((DrawingDTO)drawingBS.Current).Id);
                        updateDrawing.ParentId = null;
                        drawingService.DrawingUpdate(updateDrawing);
                    }
                    LoadData();
                }

                drawingGridView.EndUpdate();

                splashScreenManager.CloseWaitForm();

            }
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void drawingTreeListGrid_CustomUnboundColumnData(object sender, DevExpress.XtraTreeList.TreeListCustomColumnDataEventArgs e)
        {
            var item = (DrawingDTO)drawingTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;

            if (item.ScanId != 0)
                e.Value = imageCollection.Images[0];
            else
                e.Value = imageCollection.Images[1];
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Add, new DrawingDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Update, (DrawingDTO)drawingBS.Current);
        }

        private void addRevisionBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Custom, (DrawingDTO)drawingBS.Current);
        }
    }
}