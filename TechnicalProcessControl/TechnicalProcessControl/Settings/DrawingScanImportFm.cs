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
using Ninject;

namespace TechnicalProcessControl.Settings
{
    public partial class DrawingScanImportFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IJournalService journalService;
        public static IReportService reportService;

        private string pathToDirectory;

        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();



        public BindingSource drawingScanBS = new BindingSource();


        public DrawingScanImportFm(List<DrawingScanDTO> drawingScanList)
        {
            InitializeComponent();

            this.drawingScanList = drawingScanList;
            LoadData();
        }


        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            splashScreenManager.ShowWaitForm();


            //var drawingsListInfo = drawingService.GetAllDrawingsProc().OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            drawingScanBS.DataSource = drawingScanList;
            scanDrawingGrid.DataSource = drawingScanBS;


            splashScreenManager.CloseWaitForm();
        }

        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            splashScreenManager.ShowWaitForm();

            for (int i = 0; i < drawingScanList.Count(); i++)
            {

                if (drawingScanList[i].FileNamePath.Length > 0)
                {
                    DrawingScanDTO createDrawingScan = new DrawingScanDTO();

                    byte[] scan =  System.IO.File.ReadAllBytes(drawingScanList[i].FileNamePath); ;

                    

                    createDrawingScan.Id = 0;
                    createDrawingScan.Scan = scan;
                    createDrawingScan.FileName = drawingScanList[i].FileName;
                    createDrawingScan.DrawingId = null;



                    try
                    {
                        drawingService.DrawingScanCreate(createDrawingScan);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось загрузить изображение " + drawingScanList[i].FileName, "Загрузка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }

                }
            }

                splashScreenManager.CloseWaitForm();
        }

        private void clearBaseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            if (MessageBox.Show("Все сканы чертежей будут удалены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                splashScreenManager.ShowWaitForm();
                if (ClearDatabase())
                    MessageBox.Show("Все сканы чертежей успешно удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Во время удаления произошла ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);

                splashScreenManager.CloseWaitForm();

            }
        }

        private bool ClearDatabase()
        {
            var allDrawingScanItem = drawingService.GetDrawingScan();
            try
            {
                foreach (var item in allDrawingScanItem)
                {
                    drawingService.DrawingScanDelete(item.Id);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}