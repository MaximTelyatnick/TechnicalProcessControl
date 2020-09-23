using Ninject.Modules;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.BLL.Services;
using TechnicalProcessControl.BLL.Interfaces;
using TerminalMKTelegramBot.Services;

namespace TerminalMKTelegramBot.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IUnitOfWorkMysql>().To<UnitOfWorkMysql>();
            Bind<IControlPanelService>().To<ControlPanelService>();
            Bind<IDrawingService>().To<DrawingService>();
            Bind<IReportService>().To<ReportService>();
            Bind<IJournalService>().To<JournalService>();
            Bind<IUserService>().To<UserService>();

        }
    }
}
