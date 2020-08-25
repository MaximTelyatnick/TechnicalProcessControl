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

            drawingService = Program.kernel.Get<IDrawingService>();

            this.drawingsDTO = drawingsDTO;
            this.techProcess001DTO = techProcess001DTO;

            techProcess001DTO.TechProcessName = drawingService.GetLastTechProcess001();
            techProcess001DTO.TechProcessFullName = drawingsDTO.Number + "_TP" + techProcess001DTO.TechProcessName.ToString();

            techProcess001Edit.Text = techProcess001DTO.TechProcessFullName;

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
            techProcess001DTO.TechProcessFullName = drawingsDTO.Number + "_TP" + techProcess001DTO.TechProcessName.ToString();
            techProcess001DTO.TechProcessPath = @"C:\TechProcess\TechProcess001\" + techProcess001DTO.TechProcessFullName + ".xls";
            techProcess001DTO.DrawingId = drawingsDTO.Id;
            techProcess001DTO.Status = 1;


            var createTechProcess = drawingService.TechProcess001Create(techProcess001DTO);

        }

        public TechProcess001DTO Return()
        {
            return techProcess001DTO;
        }
    }
}