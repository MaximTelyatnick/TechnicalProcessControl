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

        private void clearBaseBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            if (MessageBox.Show("Все элементы структуры будут удалены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                splashScreenManager.ShowWaitForm();
                var allStructuraItem = drawingService.GetDrawingsSimple();
                try
                {
                    foreach (var item in allStructuraItem)
                    {
                        drawingService.DrawingsDelete(item.Id);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Во время удаления произошла ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    splashScreenManager.CloseWaitForm();
                    return;
                }
                splashScreenManager.CloseWaitForm();
                MessageBox.Show("Все элементы структуры успешно удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(drawingsList.Count>0)
            {
                foreach (var item in drawingsList)
                {
                    int currentStructuraId = 0;

                    



                }
            }
            else
            {
                MessageBox.Show("Не найдены элементы структуры!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}