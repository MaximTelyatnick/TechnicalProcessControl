using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services;
using TerminalMK.BLL.Interfaces;
using Ninject;
using TerminalMKTelegramBot.Infrastructure;
using TerminalMK.BLL.ModelsDTO;

namespace TerminalMKApi
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        public static IKernel kernel = new StandardKernel(new ServiceModule());

        

        IControlPanelService controlPanelService = kernel.Get<IControlPanelService>();

        //public static IKernel kernel = new StandardKernel(new ServiceModule());

        
        [WebMethod]
        public List<ProductionDTO> GetAllTutorial()
        {
            return controlPanelService.GetProduction().ToList();
        }



       

        [WebGet(UriTemplate = "/Tutorial")]

        public List<ProductionDTO> GetAllTutorials() => controlPanelService.GetProduction().ToList();
    }
}
