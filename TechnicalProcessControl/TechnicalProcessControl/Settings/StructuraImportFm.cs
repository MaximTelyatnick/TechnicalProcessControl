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

namespace TechnicalProcessControl.Settings
{
    public partial class StructuraImportFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IJournalService journalService;
        public static IReportService reportService;

        private List<DrawingsDTO> drawingsList = new List<DrawingsDTO>();



        private int viewType = 0;
        private bool materialShow = false;


        public BindingSource drawingsBS = new BindingSource();

        public StructuraImportFm(List<DrawingsDTO> drawingsList)
        {
            InitializeComponent();
            this.drawingsList = drawingsList;
            LoadData();
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            splashScreenManager.ShowWaitForm();
            

            //var drawingsListInfo = drawingService.GetAllDrawingsProc().OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            drawingsBS.DataSource = drawingsList;
            drawingTreeListGrid.DataSource = drawingsBS;
            drawingTreeListGrid.KeyFieldName = "Id";
            drawingTreeListGrid.ParentFieldName = "ParentId";
            drawingTreeListGrid.ExpandAll();

            splashScreenManager.CloseWaitForm();
        }
    }
}