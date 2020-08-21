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

namespace TechnicalProcessControl
{
    public partial class TechProcess001EditFm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static IReportService reportService;

        public DrawingsDTO drawingsDTO;
        public TechProcess001DTO techProcess001DTO;

        public TechProcess001EditFm(TechProcess001DTO techProcess001DTO, DrawingsDTO drawingsDTO)
        {
            InitializeComponent();

            this.drawingsDTO = drawingsDTO;
            this.techProcess001DTO = techProcess001DTO;

            techProcess001DTO.TechProcessName = drawingService.GetLastTechProcess001();
            techProcess001DTO.TechProcessFullName = drawingsDTO.Number + "_" + techProcess001DTO.TechProcessName.ToString() + techProcess001DTO.Article;



        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            string techProcessName = techProcess001Edit.Text;
        
            if(drawingService.CheckTechProcess001(techProcessName))
            {
                MessageBox.Show("Техпроцесс с таким номером уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            //techProcess001DTO.TechProcessName = drawingService.GetLastTechProcess001();
            //techProcess001DTO.TechProcessPath = @"C:\TechProcess\" + techProcess001DTO.TechProcessName.ToString() + ".xls";

            //var createTechProcess = drawingService.TechProcess001Create(techProcess001DTO);

            //if (createTechProcess > 0)
            //{
            //    ((DrawingsDTO)Item).TechProcess001Id = createTechProcess;
            //    ((DrawingsDTO)Item).TechProcess001Path = techProcess001DTO.TechProcessPath;
            //    ((DrawingsDTO)Item).TechProcess001Name = techProcess001DTO.TechProcessName;

            //    drawingService.DrawingUpdate(((DrawingsDTO)Item));
            //    reportService.CreateTemplateTechProcess001(((DrawingsDTO)Item));
            //    LoadData();

            //}
            //else
            //{
            //    MessageBox.Show("При формировании щаблона техпроцесса возникла ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}