﻿using System;
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
using DevExpress.XtraSplashScreen;

namespace TechnicalProcessControl.TechnicalProcess
{
    public partial class TechProcess005Fm : DevExpress.XtraEditors.XtraForm
    {
        public static IDrawingService drawingService;
        public static ITechProcessService techProcessService;
        public static IReportService reportService;
        private SplashScreenManager splashScreenManager;

        private UsersDTO usersDTO;

        public BindingSource techProcess005BS = new BindingSource();

        private ObjectBase Item
        {
            get { return techProcess005BS.Current as ObjectBase; }
            set
            {
                techProcess005BS.DataSource = value;
                value.BeginEdit();
            }
        }

        public TechProcess005Fm(UsersDTO usersDTO)
        {
            InitializeComponent();
            splashScreenManager = new SplashScreenManager(this, typeof(WaitFm), true, true);

            this.usersDTO = usersDTO;


            LoadData();
            UserAcces();
        }

        private void UserAcces()
        {
            switch (usersDTO.RoleId)
            {
                case 1:
                    deleteBtn.Enabled = true;
                    //админ
                    break;
                case 2:
                    deleteBtn.Enabled = true;
                    //технолог
                    break;
                case 3:
                    deleteBtn.Enabled = false;
                    //конструктор
                    break;
                case 4:
                    deleteBtn.Enabled = false;
                    //Пользователь без прав
                    break;
                default:
                    break;
            }
        }

        public void LoadData()
        {
            drawingService = Program.kernel.Get<IDrawingService>();
            reportService = Program.kernel.Get<IReportService>();
            techProcessService = Program.kernel.Get<ITechProcessService>();

            splashScreenManager.ShowWaitForm();

            techProcess005BS.DataSource = techProcessService.GetAllTechProcess005();

            techProcessTreeListGrid.DataSource = techProcess005BS;
            techProcessTreeListGrid.KeyFieldName = "Id";
            techProcessTreeListGrid.ParentFieldName = "ParentId";
            techProcessTreeListGrid.ExpandAll();


            splashScreenManager.CloseWaitForm();
        }

        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (((TechProcess005DTO)Item).ParentId != null)
            {
                MessageBox.Show("Невозможно удалить техпроцесс который не является последней ревизией.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (((TechProcess005DTO)Item).TechProcessName == 100050000)
            {
                MessageBox.Show("Невозможно удалить корневой техпроцесс.", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (MessageBox.Show("Удалить Техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (((TechProcess005DTO)Item).DrawingId != null)
                    if (MessageBox.Show("Техпроцесс имеет привязку чертежу, удалить техпроцесс?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;


                drawingService = Program.kernel.Get<IDrawingService>();

                if (drawingService.TechProcess005Delete(((TechProcess005DTO)techProcess005BS.Current).Id))
                {
                    //drawingService.FileDelete(((TechProcess001DTO)Item).TechProcessPath);

                    techProcessTreeListGrid.BeginUpdate();
                    LoadData();
                    techProcessTreeListGrid.EndUpdate();
                }
            }
        }

        private void techProcessTreeListGrid_DoubleClick(object sender, EventArgs e)
        {
            if (((TechProcess005DTO)techProcess005BS.Current).TechProcessPath != null)
            {
                reportService.OpenExcelFile(((TechProcess005DTO)techProcess005BS.Current).TechProcessPath);
            }
            else
            {
                MessageBox.Show("Техпроцесс не имеет файла в бд. Необходимо пересоздать техпроцесс!", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void techProcessTreeListGrid_NodeCellStyle(object sender, DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs e)
        {
            var item = (TechProcess005DTO)techProcessTreeListGrid.GetDataRecordByNode(e.Node);

            if (item == null)
                return;


            if (item.TypeId != null && e.Column.FieldName == "TechProcessName")
            {
                switch (item.TypeId)
                {
                    case 1:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkBlue;

                        break;
                    case 2:

                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Gray;
                        break;
                    case 3:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.Green;
                        break;
                    case 4:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkRed;
                        break;
                    case 5:
                        e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                        e.Appearance.ForeColor = Color.DarkOrange;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}