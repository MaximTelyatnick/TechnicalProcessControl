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
using System.IO;

namespace TechnicalProcessControl.Settings
{
    public partial class StructuraImportFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IJournalService journalService;
        public static IReportService reportService;

        private string pathToDirectory;

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
                if(ClearDatabase())
                    MessageBox.Show("Все элементы структуры успешно удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Во время удаления произошла ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);

                splashScreenManager.CloseWaitForm();
                
            }

        }

        private bool ClearDatabase()
        {
            var allStructuraItem = drawingService.GetDrawingsSimple();
            try
            {
                foreach (var item in allStructuraItem)
                {
                    drawingService.DrawingsDelete(item.Id);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void importBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            journalService = Program.kernel.Get<IJournalService>();
            drawingService = Program.kernel.Get<IDrawingService>();

            if (ClearDatabase())
                MessageBox.Show("Все элементы структуры успешно удалены!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Во время удаления произошла ошибка", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Error);

            splashScreenManager.ShowWaitForm();

            if (drawingsList.Count>0)
            {
                int j = 0;

                for(int i = 0; i< drawingsList.Count;++i)
                {
                    DrawingsDTO drawingsDTO = new DrawingsDTO();

                    var drw = drawingService.CheckDrawing(drawingsList[i].Number);

                    if (drw == null)
                    {
                        DrawingDTO drawingDTO = new DrawingDTO();
 
                        if(journalService.CheckMaterial(drawingsList[i].MaterialName)==null)
                        {
                            MaterialsDTO materialsDTO = new MaterialsDTO();
                            materialsDTO.MaterialName = drawingsList[i].MaterialName;
                            materialsDTO.Id = journalService.MaterialsCreate(materialsDTO);
                            drawingDTO.MaterialId = materialsDTO.Id;
                        }
                        else
                        {
                            drawingDTO.MaterialId = journalService.CheckMaterial(drawingsList[i].MaterialName);
                        }

                        if (journalService.CheckDetail(drawingsList[i].DetailName) == null)
                        {
                            DetailsDTO detailsDTO = new DetailsDTO();
                            detailsDTO.DetailName = drawingsList[i].DetailName;
                            detailsDTO.Id = journalService.DetailCreate(detailsDTO);
                            drawingDTO.DetailId = detailsDTO.Id;
                        }
                        else
                        {
                            drawingDTO.DetailId = journalService.CheckDetail(drawingsList[i].DetailName);
                        }

                        if (drawingService.CheckType(drawingsList[i].TypeName) == null)
                        {
                            TypeDTO typeDTO = new TypeDTO();
                            typeDTO.TypeName = drawingsList[i].TypeName;
                            typeDTO.Id = drawingService.TypeCreate(typeDTO);
                            drawingDTO.TypeId = typeDTO.Id;
                        }
                        else
                        {
                            drawingDTO.TypeId = drawingService.CheckType(drawingsList[i].TypeName);
                        }

                        drawingDTO.TH = drawingsList[i].TH;
                        drawingDTO.W = drawingsList[i].W;
                        drawingDTO.W2 = drawingsList[i].W2;
                        drawingDTO.L = drawingsList[i].L;
                        drawingDTO.Number = drawingsList[i].Number;
                        drawingDTO.CreateDate = DateTime.Now;
                        drawingDTO.Id = drawingService.DrawingCreate(drawingDTO);
                        drawingsDTO.DrawingId = drawingDTO.Id;


                    }
                    else
                    {
                        drawingsDTO.DrawingId = drawingService.CheckDrawing(drawingsList[i].Number);
                    }

                    


                    drawingsDTO.Quantity = drawingsList[i].Quantity;
                    drawingsDTO.QuantityR = drawingsList[i].QuantityR;
                    drawingsDTO.QuantityL = drawingsList[i].QuantityL;


                    drawingsList[i].IdFake = drawingsList[i].Id;
                    drawingsList[i].ParentIdFake = drawingsList[i].ParentId;
                    drawingsList[i].ParentId = null;

                    

                    var parentId = drawingsList.FirstOrDefault(srch => srch.IdFake == drawingsList[i].ParentIdFake);

                    if (parentId != null)
                    {
                        drawingsDTO.ParentId = parentId.Id;
                        drawingsList[i].ParentId = parentId.Id;
                    }
                    drawingsDTO.CurrentLevelMenu = drawingsList[i].CurrentLevelMenu;
                    drawingsDTO.Id = drawingService.DrawingsCreate(drawingsDTO);
                    drawingsList[i].Id = drawingsDTO.Id;


                    //if (i > 1000)
                    //    break;



                }

                //foreach (var item in drawingsList)
                //{
                    

                //    //int currentStructuraId = 0;

                //    //if(item.TypeName!="" || item.TypeName!=null)
                //    //{
                //    //    if(drawingService.CheckType(item.TypeName)!=null)
                //    //        drawingsDTO.

                //    //}




                //    //Id = j,
                //    //            CurrentLevelMenu = Convert.ToString(Сells["C" + i].Value),
                //    //            ParentId = lastFirstLevelParent,
                //    //            Quantity = ParseDecimalValue(Сells["I" + i].Value),
                //    //            QuantityR = ParseDecimalValue(Сells["G" + i].Value),
                //    //            QuantityL = ParseDecimalValue(Сells["H" + i].Value),
                //    //            DetailName = Convert.ToString(Сells["F" + i].Value),
                //    //            Number = Convert.ToString(Сells["D" + i].Value),
                //    //            TypeName = Convert.ToString(Сells["A" + i].Value) != "" ? Convert.ToString(Сells["A" + i].Value) : Convert.ToString(Сells["B" + i].Value),
                //    //            MaterialName = Convert.ToString(Сells["L" + i].Value),
                //    //            TH = Convert.ToString(Сells["M" + i].Value),
                //    //            W = Convert.ToString(Сells["N" + i].Value),
                //    //            W2 = Convert.ToString(Сells["O" + i].Value),
                //    //            L = Convert.ToString(Сells["P" + i].Value)

                //}
            }
            else
            {
                MessageBox.Show("Не найдены элементы структуры!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            splashScreenManager.CloseWaitForm();
        }

      
    }
}