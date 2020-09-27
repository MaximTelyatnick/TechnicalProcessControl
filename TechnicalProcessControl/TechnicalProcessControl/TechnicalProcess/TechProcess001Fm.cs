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

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess001Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        private UsersDTO usersDTO;

        public BindingSource drawingsBS = new BindingSource();

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

            drawingsBS.DataSource = drawingService.GetAllTechProcess001();

            techProcessTreeListGrid.DataSource = drawingsBS;
            techProcessTreeListGrid.KeyFieldName = "Id";
            techProcessTreeListGrid.ParentFieldName = "ParentId";
            techProcessTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }
    }
}