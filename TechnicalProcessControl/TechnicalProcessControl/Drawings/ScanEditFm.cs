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
using TechnicalProcessControl.BLL.Infrastructure;
using Ninject;
using DevExpress.XtraEditors.Controls;

namespace TechnicalProcessControl.Drawings
{
    public partial class ScanEditFm : DevExpress.XtraEditors.XtraForm
    {
        private IDrawingService drawingService;

        private Utils.Operation operation;

        private BindingSource drawingBS = new BindingSource();
        private BindingSource drawingScanBS = new BindingSource();

        private UsersDTO usersDTO;


        private ObjectBase Item
        {
            get { return drawingScanBS.Current as ObjectBase; }
            set
            {
                drawingScanBS.DataSource = value;
                value.BeginEdit();
            }
        }

        public ScanEditFm(UsersDTO usersDTO, DrawingScanDTO model, Utils.Operation operation)
        {
            InitializeComponent();
            this.usersDTO = usersDTO;

            drawingService = Program.kernel.Get<IDrawingService>();

            this.operation = operation;

            drawingScanBS.DataSource = Item = model;

            drawingNumberEdit.DataBindings.Add("EditValue", drawingScanBS, "DrawingId", true, DataSourceUpdateMode.OnPropertyChanged);
            drawingBS.DataSource = drawingService.GetAllDrawing();
            drawingNumberEdit.Properties.DataSource = drawingBS;
            drawingNumberEdit.Properties.ValueMember = "Id";
            drawingNumberEdit.Properties.DisplayMember = "FullName";
            drawingNumberEdit.Properties.NullText = "";

            fileNameEdit.DataBindings.Add("EditValue", drawingScanBS, "FileName", true, DataSourceUpdateMode.OnPropertyChanged);


            if (operation == Utils.Operation.Add)
            {


            }
            else if (operation == Utils.Operation.Update)
            {
                LoadScan();
            }
        }

        public void LoadScan()
        {

            if (((DrawingScanDTO)Item).Scan != null)
            {
                int stratIndex = ((DrawingScanDTO)Item).FileName.IndexOf('.');
                string typeFile = ((DrawingScanDTO)Item).FileName.Substring(stratIndex);

                switch (typeFile)
                {
                    default:
                        //Bitmap bitmap = new Bitmap(drawingScanDTO.Scan);
                        ImageConverter ic = new ImageConverter();

                        Image img = (Image)ic.ConvertFrom(((DrawingScanDTO)Item).Scan);

                        Bitmap bitmap1 = new Bitmap(img);

                        pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                        pictureEdit.EditValue = bitmap1;
                        //fileNameTbox.EditValue = drawingScanDTO.FileName;
                        break;
                }
            }
        }

        private void addScanBtn_Click(object sender, EventArgs e)
        {

            string filePath = "";
            string fileName = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"D:\";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                fileName = ofd.SafeFileName;
            }
            if (filePath.Length > 0)
            {
                byte[] scan = System.IO.File.ReadAllBytes(@filePath);
                ((DrawingScanDTO)Item).Scan = scan;
                //((DrawingScanDTO)Item).FileName = fileName;
                fileNameEdit.EditValue = fileName;
                try
                {
                    //int drawingScanId = drawingService.DrawingScanCreate(drawingScanDTO);
                    //drawingScanList.Add(drawingScanDTO);
                    //drawingScanEdit.EditValue = drawingScanId;
                    //drawingScanEdit.Text = drawingScanDTO.FileName;

                    //Bitmap bitmap = new Bitmap(filePath);
                    //pictureEdit.Properties.SizeMode = PictureSizeMode.Zoom;
                    //pictureEdit.EditValue = bitmap;
                    //fileNameTbox.EditValue = fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При добавлении скана возникла ошибка. " + ex.Message, "Сохранение чертежа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
                return;

            LoadScan();
        }

        public DrawingScanDTO Return()
        {
            return (DrawingScanDTO)Item;
        }

        private void deleteScanBtn_Click(object sender, EventArgs e)
        {
            ((DrawingScanDTO)Item).Scan = null;
            fileNameEdit.EditValue = null;
            pictureEdit.EditValue = null;



        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сохранить изменения?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (SaveItem())
                    {
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("При сохранении возникла ошибка. " + ex.Message, "Сохранение контрагента", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private bool SaveItem()
        {
            this.Item.EndEdit();
            drawingService = Program.kernel.Get<IDrawingService>();

            if (operation == Utils.Operation.Add)
            {
                ((DrawingScanDTO)Item).Id = drawingService.DrawingScanCreate((DrawingScanDTO)Item);
                return true;
            }
            else
            {

                drawingService.DrawingScanUpdate((DrawingScanDTO)Item);
                return true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Item.CancelEdit();
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}