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
using TechnicalProcessControl.BLL.ModelsDTO;
using Ninject;
using TechnicalProcessControl.BLL.Infrastructure;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess001Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        private UsersDTO usersDTO;

        public BindingSource techProcess001BS = new BindingSource();

        private ObjectBase Item
        {
            get { return techProcess001BS.Current as ObjectBase; }
            set
            {
                techProcess001BS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess001Fm(UsersDTO usersDTO)
        {
            InitializeComponent();

            this.usersDTO = usersDTO;


            LoadData();


        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();

            splashScreenManager.ShowWaitForm();

            techProcess001BS.DataSource = drawingService.GetAllTechProcess001();

            techProcessTreeListGrid.DataSource = techProcess001BS;
            techProcessTreeListGrid.KeyFieldName = "Id";
            techProcessTreeListGrid.ParentFieldName = "ParentId";
            techProcessTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((TechProcess001DTO)Item).ParentId != null)
            {
                MessageBox.Show("Невозможно удалить техпроцесс который не является последней ревизией.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Удалить Техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((TechProcess001DTO)Item).DrawingId != null)
                    if (MessageBox.Show("Техпроцесс имеет привязку чертежу, удалить техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                drawingService = Program.kernel.Get<IDrawingService>();

                if (drawingService.TechProcess001Delete(((TechProcess001DTO)techProcess001BS.Current).Id))
                {
                    techProcessTreeListGrid.BeginUpdate();
                    LoadData();
                    techProcessTreeListGrid.EndUpdate();
                }
            }
        }

        private void techProcessTreeListGrid_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            var item = (TechProcess001DTO)techProcessTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;


            if (item.TypeId != null && e.Column.FieldName == "TechProcessName")
            {
                switch (item.TypeId)
                {
                    case 1:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkBlue;

                        break;
                    case 2:

                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Gray;
                        break;
                    case 3:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Green;
                        break;
                    case 4:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkOrange;
                        break;
                    case 5:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkRed;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}