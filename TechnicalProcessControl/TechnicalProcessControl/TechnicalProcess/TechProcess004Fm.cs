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
using DevExpress.XtraSplashScreen;
using TechnicalProcessControl.BLL.ModelsDTO;
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess004Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;
        private SplashScreenManager splashScreenManager;

        private UsersDTO usersDTO;

        public BindingSource techProcess004BS = new BindingSource();

        private ObjectBase Item
        {
            get { return techProcess004BS.Current as ObjectBase; }
            set
            {
                techProcess004BS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess004Fm()
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

            techProcess004BS.DataSource = drawingService.GetAllTechProcess004();

            techProcessTreeListGrid.DataSource = techProcess004BS;
            techProcessTreeListGrid.KeyFieldName = "Id";
            techProcessTreeListGrid.ParentFieldName = "ParentId";
            techProcessTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((TechProcess004DTO)Item).ParentId != null)
            {
                MessageBox.Show("Невозможно удалить техпроцесс который не является последней ревизией.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (((TechProcess004DTO)Item).TechProcessName == 100040000)
            {
                MessageBox.Show("Невозможно удалить корневой техпроцесс.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Удалить Техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((TechProcess004DTO)Item).DrawingId != null)
                    if (MessageBox.Show("Техпроцесс имеет привязку чертежу, удалить техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                drawingService = Program.kernel.Get<IDrawingService>();

                if (drawingService.TechProcess004Delete(((TechProcess004DTO)techProcess004BS.Current).Id))
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