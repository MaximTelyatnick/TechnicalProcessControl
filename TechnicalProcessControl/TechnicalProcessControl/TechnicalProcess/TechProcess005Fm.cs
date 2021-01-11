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
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Interfaces;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;
using DevExpress.XtraSplashScreen;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess005Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;
        private SplashScreenManager splashScreenManager;

        private UsersDTO usersDTO;

        public BindingSource techProcess005BS = new BindingSource();

        private ObjectBase Item
        {
            get { return techProcess005BS.Current as ObjectBase; }
            set
            {
                techProcess005BS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess005Fm(UsersDTO usersDTO)
        {
            InitializeComponent();
            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);

            this.usersDTO = usersDTO;


            LoadData();
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();

            splashScreenManager.ShowWaitForm();

            techProcess005BS.DataSource = drawingService.GetAllTechProcess001();

            techProcessTreeListGrid.DataSource = techProcess005BS;
            techProcessTreeListGrid.KeyFieldName = "Id";
            techProcessTreeListGrid.ParentFieldName = "ParentId";
            techProcessTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((TechProcess005DTO)Item).ParentId != null)
            {
                MessageBox.Show("Невозможно удалить техпроцесс который не является последней ревизией.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (((TechProcess005DTO)Item).TechProcessName == 100050000)
            {
                MessageBox.Show("Невозможно удалить корневой техпроцесс.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Удалить Техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((TechProcess005DTO)Item).DrawingId != null)
                    if (MessageBox.Show("Техпроцесс имеет привязку чертежу, удалить техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                drawingService = Program.kernel.Get<IDrawingService>();

                if (drawingService.TechProcess005Delete(((TechProcess005DTO)techProcess005BS.Current).Id))
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