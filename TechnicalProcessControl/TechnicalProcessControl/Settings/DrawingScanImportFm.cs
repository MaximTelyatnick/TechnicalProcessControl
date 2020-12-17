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
            splashScreenManager3.ShowWaitForm();


            //var drawingsListInfo = drawingService.GetAllDrawingsProc().OrderBy(bdsm => Convert.ToInt32(bdsm.CurrentLevelMenu.Split('.').Last())).ToList();
            drawingScanBS.DataSource = drawingScanList;
            scanDrawingGrid.DataSource = drawingScanBS;


            splashScreenManager3.CloseWaitForm();
        }

        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            splashScreenManager3.ShowWaitForm();

            for (int i = 0; i < drawingScanList.Count(); i++)
            {

                if (drawingScanList[i].FileNamePath.Length > 0)
                {
                    DrawingScanDTO createDrawingScan = new DrawingScanDTO();

                    byte[] scan =  System.IO.File.ReadAllBytes(drawingScanList[i].FileNamePath);

                    

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
                        splashScreenManager3.CloseWaitForm();
                        MessageBox.Show("Не получилось загрузить изображение " + drawingScanList[i].FileName, "Загрузка изображения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        splashScreenManager3.ShowWaitForm();
                        continue;
                    }

                }
            }

             splashScreenManager3.CloseWaitForm();
             MessageBox.Show("Загрузка изображений завершена!", "Загрузка изображения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearBaseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            if (MessageBox.Show("Все сканы чертежей будут удалены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                splashScreenManager3.ShowWaitForm();
                if (ClearDatabase())
                {
                    splashScreenManager3.CloseWaitForm();
                    MessageBox.Show("Все сканы чертежей успешно удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    splashScreenManager3.CloseWaitForm();
                    MessageBox.Show("Во время удаления произошла ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

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

        private void syncDrawingScanBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            List<DrawingScanDTO> allDrawingScanItem = drawingService.GetDrawingScan().ToList();
            List<DrawingScanDTO> allDrawingScanItemTransform = new List<DrawingScanDTO>();

            List<DrawingDTO> allDrawingItem = drawingService.GetAllDrawing().ToList();
            List<DrawingDTO> allDrawingItemTransform = new List<DrawingDTO>();

            //allDrawingScanItemTransform.AddRange(allDrawingScanItem);
            allDrawingItemTransform.AddRange(allDrawingItem);
            //allDrawingScanItem = allDrawingItem.Cop
            //foreach (var item in allDrawingScanItem)
            //{
            //    allDrawingScanItemTransform.Add(item);
            //}


            allDrawingScanItemTransform = allDrawingScanItem.Select(p => new DrawingScanDTO()
            {
                 Id = p.Id,
                  Check = p.Check,
                   DrawingId = p.DrawingId,
                    FileName = p.FileName,
                     FileNamePath = p.FileNamePath,
                      Scan = p.Scan,
                       Status =p.Status
            }).ToList();

            try
            {
                for(int i=0; i< allDrawingScanItemTransform.Count();++i)
                {
                    allDrawingScanItemTransform[i].FileName = allDrawingScanItemTransform[i].FileName.Replace(@".tif", "");
                    allDrawingScanItemTransform[i].FileName = allDrawingScanItemTransform[i].FileName.Replace(@"-", "");
                    allDrawingScanItemTransform[i].FileName = allDrawingScanItemTransform[i].FileName.Replace(@"_", "");
                    allDrawingScanItemTransform[i].FileName = allDrawingScanItemTransform[i].FileName.Replace(@"asm", "");
                    allDrawingScanItemTransform[i].FileName = allDrawingScanItemTransform[i].FileName.ToUpper();
                }

                for (int i = 0; i < allDrawingItemTransform.Count(); ++i)
                {
                    allDrawingItemTransform[i].Number = allDrawingItemTransform[i].Number.Replace(@"-", "");
                    allDrawingItemTransform[i].Number = allDrawingItemTransform[i].Number.Replace(@"_", "");
                    allDrawingItemTransform[i].Number = allDrawingItemTransform[i].Number.Replace(@" ", "");
                    allDrawingItemTransform[i].Number = allDrawingItemTransform[i].Number.Replace(@".", "");
                    allDrawingItemTransform[i].Number = allDrawingItemTransform[i].Number.Replace(@"/", "");
                    allDrawingItemTransform[i].Number = allDrawingItemTransform[i].Number.ToUpper();
                }
                int findDrawing = 0, notFindDrawing = 0;
                for (int i = 0; i < allDrawingScanItemTransform.Count(); ++i)
                {

                    var drawings = allDrawingItemTransform.FirstOrDefault(bdsm=>bdsm.Number == allDrawingScanItemTransform[i].FileName);

                    if (drawings!=null)
                    {
                        findDrawing++;
                        allDrawingScanItemTransform[i].Check = true;

                        allDrawingScanItem[i].DrawingId = drawings.Id;
                        drawingService.DrawingScanUpdate(allDrawingScanItem[i]);

                    }
                    else
                    {
                        notFindDrawing++;
                        allDrawingScanItemTransform[i].Check = false;
                    }

                }

                MessageBox.Show("Найдено чертежей:" + findDrawing +", не найдено чертежей: "+ notFindDrawing, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                drawingScanBS.DataSource = allDrawingScanItemTransform;
                scanDrawingGrid.DataSource = drawingScanBS;

            }
            catch (Exception)
            {

            }



        }
    }
}