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

        public DrawingFm()
        {
            InitializeComponent();
            splashScreenManager.ShowWaitForm();
            LoadData();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            drawingService = Program.kernel.Get<IDrawingService>();
            var drawing = drawingService.GetAllDrawing();
            drawingBS.DataSource = drawing;
            drawingGrid.DataSource = drawingBS;
        }

        public void EditDrawing(Utils.Operation operation, DrawingDTO drawingDTO)
        {
            //List<DrawingScanDTO> drawingScanList = drawingService.GetDravingScanById(); 

            using (DrawingEditFm drawingEditFm = new DrawingEditFm(drawingDTO, operation))
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
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Add, new DrawingDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawing(Utils.Operation.Update, (DrawingDTO)drawingBS.Current);
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Удалить чертеж?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                drawingService = Program.kernel.Get<IDrawingService>();

                drawingGridView.BeginUpdate();

                if (drawingService.DrawingDelete(((DrawingDTO)drawingBS.Current).Id))
                {
                    LoadData();
                }

                drawingGridView.EndUpdate();
            }
        }

        private void updateBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }
    }
}