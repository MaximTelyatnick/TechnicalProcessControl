using System.Windows.Forms;
using TechnicalProcessControl.BLL.Interfaces;
using Ninject;

namespace TechnicalProcessControl
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