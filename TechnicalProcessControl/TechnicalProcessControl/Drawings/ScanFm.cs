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
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Controls;
using TechnicalProcessControl.Drawings;

namespace TechnicalProcessControl.Journals
{
    public partial class ScanFm : DevExpress.XtraEditors.XtraForm
    {
        private SplashScreenManager splashScreenmanager;
        public IDrawingService drawingService;
        public BindingSource drawingScanBS = new BindingSource();

        private List<DrawingScanDTO> drawingScanList = new List<DrawingScanDTO>();

        private UsersDTO usersDTO;

        public ScanFm(UsersDTO usersDTO)
        {
            InitializeComponent();

            this.usersDTO = usersDTO;
            splashScreenmanager = new SplashScreenManager(this, typeof(WaitFm), true, true);

            LoadData();
        }

        private void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();

            splashScreenmanager.ShowWaitForm();
            drawingScanList = drawingService.GetDrawingScanWithaoutScan().ToList();
            drawingScanBS.DataSource = drawingScanList;
            scanGrid.DataSource = drawingScanBS;
            splashScreenmanager.CloseWaitForm();

        }

        private void scanGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DrawingScanDTO drawingScanDTO = drawingService.GetDrawingScanById(((DrawingScanDTO)drawingScanBS.Current).Id);

            if (drawingScanDTO.Scan != null)
            {
                int stratIndex = drawingScanDTO.FileName.IndexOf('.');
                string typeFile = drawingScanDTO.FileName.Substring(stratIndex);

                switch (typeFile)
                {
                    default:
                        ImageConverter ic = new ImageConverter();
                        Image img = (Image)ic.ConvertFrom(drawingScanDTO.Scan);
                        Bitmap bitmap1 = new Bitmap(img);
                        pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                        pictureEdit.EditValue = bitmap1;
                        break;
                }
            }
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            scanGridView.PostEditor();

            scanGridView.BeginDataUpdate();

            var deleteDrawingScans = drawingScanList.Where(t => (bool)t.Check);

            foreach (var item in deleteDrawingScans)
            {
                drawingService.DrawingScanDelete(item.Id);

            }

            LoadData();
            //(List<DrawingScanDTO>)
            //if (deleteDrawingScans.Count() > 0)
            //{
            //    drawingScanList.RemoveAll(s => (bool)s.Check);

            //    foreach (var item in deleteDrawingScans)
            //    {
            //        drawingService.DrawingScanDelete(item.Id);

            //    }

            //    drawingScanBS.DataSource = drawingScanList;
            //    scanGrid.DataSource = drawingScanBS;
            //}

            scanGridView.EndDataUpdate();
        }

        private void pictureEdit_Click(object sender, EventArgs e)
        {
            DrawingScanDTO drawingScanDTO = drawingService.GetDrawingScanById(((DrawingScanDTO)drawingScanBS.Current).Id);
            if (drawingScanDTO != null)
            {
                if (Properties.Settings.Default.UserDirectoryPath != "")
                {
                    string puth = Properties.Settings.Default.UserDirectoryPath + @"\Temp";
                    System.IO.File.WriteAllBytes(puth + drawingScanDTO.FileName, drawingScanDTO.Scan);
                    System.Diagnostics.Process.Start(puth + drawingScanDTO.FileName);
                }
                else
                {
                    MessageBox.Show("В настройках не указан рабочий каталог пользователя!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void EditDrawingScan(Utils.Operation operation, DrawingScanDTO drawingScanDTO)
        {
            //List<DrawingScanDTO> drawingScanList = drawingService.GetDravingScanById(); 

            using (ScanEditFm scanEditFm = new ScanEditFm(usersDTO, drawingScanDTO, operation))
            {
                if (scanEditFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DrawingScanDTO return_Id = scanEditFm.Return();
                    scanGridView.PostEditor();
                    scanGridView.BeginUpdate();
                    LoadData();
                    scanGridView.EndUpdate();
                    int rowHandle = scanGridView.LocateByValue("Id", return_Id.Id);
                    scanGridView.FocusedRowHandle = rowHandle;

                }
                else
                {
                    scanGridView.BeginUpdate();
                    LoadData();
                    scanGridView.EndUpdate();

                }
            }
        }

        private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditDrawingScan(Utils.Operation.Add, new DrawingScanDTO());
        }

        private void editBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DrawingScanDTO drawingScanDTO = drawingService.GetDrawingScanById(((DrawingScanDTO)drawingScanBS.Current).Id);

            EditDrawingScan(Utils.Operation.Update, drawingScanDTO);
        }
    }
}