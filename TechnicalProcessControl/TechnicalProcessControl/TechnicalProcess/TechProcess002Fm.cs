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
using TechnicalProcessControl.BLL.Infrastructure;
using TechnicalProcessControl.BLL.ModelsDTO;
using Ninject;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess002Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;
        public static ITechProcessService techProcessService;

        private UsersDTO usersDTO;

        public BindingSource techProcess002BS = new BindingSource();

        private ObjectBase Item
        {
            get { return techProcess002BS.Current as ObjectBase; }
            set
            {
                techProcess002BS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess002Fm(UsersDTO usersDTO)
        {
            InitializeComponent();
            this.usersDTO = usersDTO;


            LoadData();
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();

            splashScreenManager.ShowWaitForm();

            techProcess002BS.DataSource = techProcessService.GetAllTechProcess002();

            techProcessTreeListGrid.DataSource = techProcess002BS;
            techProcessTreeListGrid.KeyFieldName = "Id";
            techProcessTreeListGrid.ParentFieldName = "ParentId";
            techProcessTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }

        private void techProcessTreeListGrid_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            var item = (TechProcess002DTO)techProcessTreeListGrid.GetDataRecordByNode(e.Node);

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
            if (((TechProcess002DTO)techProcess002BS.Current).TechProcessPath != null)
            {
                reportService.OpenExcelFile(((TechProcess002DTO)techProcess002BS.Current).TechProcessPath);
            }
            else
            {
                MessageBox.Show("Техпроцесс не имеет файла в бд. Необходимо пересоздать техпроцесс!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void techProcessTreeListGrid_DoubleClick(object sender, EventArgs e)
        {
            if (((TechProcess002DTO)techProcess002BS.Current).TechProcessPath != null)
            {
                reportService.OpenExcelFile(((TechProcess002DTO)techProcess002BS.Current).TechProcessPath);
            }
            else
            {
                MessageBox.Show("Техпроцесс не имеет файла в бд. Необходимо пересоздать техпроцесс!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((TechProcess002DTO)Item).ParentId != null)
            {
                MessageBox.Show("Невозможно удалить техпроцесс который не является последней ревизией.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (((TechProcess002DTO)Item).TechProcessName == 100020000)
            {
                MessageBox.Show("Невозможно удалить корневой техпроцесс.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Удалить Техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((TechProcess002DTO)Item).DrawingId != null)
                    if (MessageBox.Show("Техпроцесс имеет привязку чертежу, удалить техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                

                if (techProcessService.TechProcess002Delete(((TechProcess002DTO)techProcess002BS.Current).Id))
                {
                   
                        //drawingService.FileDelete(((TechProcess001DTO)Item).TechProcessPath);

                        techProcessTreeListGrid.BeginUpdate();
                        LoadData();
                        techProcessTreeListGrid.EndUpdate();
                    
                }
            }
        }
    }
}