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
using TerminalMK.BLL.Interfaces;
using Ninject;

namespace TerminalMKBot
{
    public partial class TestFm : DevExpress.XtraEditors.XtraForm
    {
        public BindingSource cityBS = new BindingSource();
        public IMySqlService mySqlService;
        public IBotService botService;
        public TestFm()
        {
            InitializeComponent();

            botService = Program.kernel.Get<IBotService>();

            mySqlService = Program.kernel.Get<IMySqlService>();
            //cityBS.DataSource = mySqlService.GetCity();
            //messagesGrid.DataSource = messagesBS;


        }
    }
}