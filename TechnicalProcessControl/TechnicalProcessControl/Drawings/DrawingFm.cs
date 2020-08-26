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
using Ninject;

namespace TechnicalProcessControl.Drawings
{
    public partial class DrawingFm : DevExpress.XtraEditors.XtraForm
    {
        public IJournalService journalService;
        public IDrawingService drawingService;
        public BindingSource drawingBS = new BindingSource();

        public DrawingFm()
        {
            InitializeComponent();
            splashScreenManager.ShowWaitForm();
            LoadData();
            splashScreenManager.CloseWaitForm();
        }

        private void LoadData()
        {
            journalService = Program.kernel.Get<IJournalService>();
            drawingService = Program.kernel.Get<IDrawingService>();
            var drawing = drawingService.GetAllDrawing();
            drawingBS.DataSource = drawing;
            drawingGrid.DataSource = drawingBS;
        }
    }
}