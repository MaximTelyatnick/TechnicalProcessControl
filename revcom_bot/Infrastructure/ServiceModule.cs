using Ninject.Modules;
using TerminalMKTelegramBot.Interfaces;
using TerminalMKTelegramBot.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
