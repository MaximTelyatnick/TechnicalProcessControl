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
using DevExpress.XtraSplashScreen;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess001Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static ITechProcessService techProcesService;
        public static IReportService reportService;
        private SplashScreenManager splashScreenManager;

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
            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);

            this.usersDTO = usersDTO;

            LoadData();
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            techProcesService = Program.kernel.Get<ITechProcessService>();
            reportService = Program.kernel.Get<IReportService>();

            splashScreenManager.ShowWaitForm();

            techProcess001BS.DataSource = techProcesService.GetAllTechProcess001();

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

            if (((TechProcess001DTO)Item).TechProcessName == 100010000)
            {
                MessageBox.Show("Невозможно удалить корневой техпроцесс.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Удалить Техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((TechProcess001DTO)Item).DrawingId != null)
                    if (MessageBox.Show("Техпроцесс имеет привязку чертежу, удалить техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                drawingService = Program.kernel.Get<IDrawingService>();

                if (techProcesService.TechProcess001Delete(((TechProcess001DTO)techProcess001BS.Current).Id))
                {
                    //drawingService.FileDelete(((TechProcess001DTO)Item).TechProcessPath);

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
                        e.Appearance.ForeColor = Color.DarkRed;
                        break;
                    case 5:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkOrange;
                        break;

                    default:
                        break;
                }
            }
        }

        private void repositoryItemTextEdit_DoubleClick(object sender, EventArgs e)
        {
            if (((TechProcess001DTO)techProcess001BS.Current).TechProcessPath != null)
            {
                reportService.OpenExcelFile(((TechProcess001DTO)techProcess001BS.Current).TechProcessPath);
            }
            else
            {
                MessageBox.Show("Техпроцесс не имеет файла в бд. Необходимо пересоздать техпроцесс!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void techProcessTreeListGrid_DoubleClick(object sender, EventArgs e)
        {
            if (((TechProcess001DTO)techProcess001BS.Current).TechProcessPath != null)
            {
                reportService.OpenExcelFile(((TechProcess001DTO)techProcess001BS.Current).TechProcessPath);
            }
            else
            {
                MessageBox.Show("Техпроцесс не имеет файла в бд. Необходимо пересоздать техпроцесс!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}