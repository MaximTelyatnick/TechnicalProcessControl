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
using Ninject;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using System.Timers;
using TerminalMK.BLL.Interfaces;
using TLSharp.Core;

namespace TerminalMKBot
{
    public partial class MainMenuFm : DevExpress.XtraEditors.XtraForm
    {
        private IControlPanelService controlPanelService;
        private BackgroundWorker messageWorker = new BackgroundWorker();

        private TelegramClient client;

        private int telegramApiId = 1090023;
        private string telegramApiHash = "3651d2c505bed6f082a7314219c848f6";
        private string userPhone;
        private string userCode;
        private string hash;
        bool isValidate;
        private FileSessionStore sessionStore;
        private System.Timers.Timer messageCheckTimer;

        public MainMenuFm()
        {
            InitializeComponent();

            messageWorker = new BackgroundWorker();

            messageWorker.DoWork += messageWorker_DoWork;

            controlPanelService = Program.kernel.Get<IControlPanelService>();
            documentManager.MdiParent = this;
            documentManager.View = new TabbedView();


            //telegram user auth
            sessionStore = new TLSharp.Core.FileSessionStore();
            client = new TelegramClient(telegramApiId, telegramApiHash, sessionStore, "session");
            client.ConnectAsync();

            CreateTimer(1000);
        }

        public void CreateTimer(int seconds)
        {
            if (messageCheckTimer == null)
            {
                messageCheckTimer = new System.Timers.Timer();
                messageCheckTimer.AutoReset = false; // Чтобы операции удаления не перекрывались
                messageCheckTimer.Interval = 1000;
                messageCheckTimer.Elapsed += OnTimedEvent;
                messageCheckTimer.Enabled = true;

                messageCheckTimer.Start();
            }
        }

        public async void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            messageCheckTimer.Stop();

            controlPanelService = Program.kernel.Get<IControlPanelService>();

            try
            {
                
                if (controlPanelService.CheckMessages())
                    msgBtn.Glyph = imageCollection.Images[1];
                else
                    msgBtn.Glyph = imageCollection.Images[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            messageCheckTimer.Start();

        }

        private void contractorBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ContractorsFm contratorsFm = new ContractorsFm(client);
            contratorsFm.Text = "Пользователи";
            contratorsFm.MdiParent = this;
            contratorsFm.Show();
        }

        private void productionBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ProductionFm productionFm = new ProductionFm();
            productionFm.Text = "Продукция";
            productionFm.MdiParent = this;
            productionFm.Show();
        }

        async void messageWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void shipmentRoadBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ShipmentRoadFm shipmentRoadFm = new ShipmentRoadFm();
            shipmentRoadFm.Text = "Маршруты";
            shipmentRoadFm.MdiParent = this;
            shipmentRoadFm.Show();
        }

        private void msgBtn_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            MessagesFm messagesFm = new MessagesFm(client);
            messagesFm.Text = "Соообщения от пользователей";
            messagesFm.MdiParent = this;
            messagesFm.Show();
        }

        private async void MainMenuFm_Load(object sender, EventArgs e)
        {
            //await client.ConnectAsync();

            if (!client.IsUserAuthorized())
            {

                using (AuthUserPhoneFm authUserPhoneFm = new AuthUserPhoneFm())
                {
                    if (authUserPhoneFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        userPhone = authUserPhoneFm.Return();
                    }
                }

                hash = await client.SendCodeRequestAsync(userPhone);

                using (AuthUserCodeFm authUserCodeFm = new AuthUserCodeFm())
                {
                    if (authUserCodeFm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        userCode = authUserCodeFm.Return();
                    }
                }

                var user = await client.MakeAuthAsync(userPhone, hash.ToString(), userCode);
                if (user != null)
                {
                    MessageBox.Show("Вы прошли авторизацию. ", "Авторизаця", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


                //var hashKey = await client.SendCodeRequestAsync(phoneNumber);
                //TLUser myuser = await client.MakeAuthAsync("+********", hashKey, TelegramSendedCode);
            }
        }
    }
}