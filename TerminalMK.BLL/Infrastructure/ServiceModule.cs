using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalMK.DAL.Interfaces;
using TerminalMK.BLL.Services;
using TerminalMK.BLL.Interfaces;
using TerminalMKTelegramBot.Services;

namespace TerminalMKTelegramBot.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IBotService>().To<BotService>();
            Bind<IControlPanelService>().To<ControlPanelService>();
        }
    }
}
