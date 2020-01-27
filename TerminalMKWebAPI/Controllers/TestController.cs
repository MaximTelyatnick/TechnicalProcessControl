using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TerminalMK.BLL.Interfaces;
using TerminalMK.BLL.ModelsDTO;
using TerminalMKTelegramBot.Infrastructure;

namespace TerminalMKWebAPI.Controllers
{
    public class TestController : ApiController
    {
        public static IKernel kernel = new StandardKernel(new ServiceModule());



        //IControlPanelService controlPanelService = kernel.Get<IControlPanelService>();
        IMySqlService mySqlService = kernel.Get<IMySqlService>();

        //  GET: api/Test

        [System.Web.Http.HttpGet]
        //public List<ProductionDTO> Get()
        //{
        //    return controlPanelService.GetProduction().ToList();
        //}

        public List<ProductionDTO> Get()
        {
            var bb = mySqlService.GetProduction().ToList();
        

            return bb;
        }
        // GET api/Test/5
        public async Task<HttpResponseMessage> Get(int id)
        {
            var production = (ProductionDTO)mySqlService.GetProduction().FirstOrDefault(bd => bd.Id == id);

            if (production != null)
                return await Task.Run(() => Request.CreateResponse(HttpStatusCode.OK, production));
            else
                return await Task.Run(() => Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not found production with id "+ id));

        }

        //public async Task<HttpResponseMessage> Get(int id)
        //{
        //    var production = (ProductionDTO)controlPanelService.GetProduction().FirstOrDefault(bd => bd.Id == id);

        //    if (production != null)
        //        return await Task.Run(() => Request.CreateResponse(HttpStatusCode.OK, production));
        //    else
        //        return await Task.Run(() => Request.CreateErrorResponse(HttpStatusCode.NotFound, "Not found production with id " + id));

        //}

        //public HttpResponseMessage Post([FromBody] ProductionDTO production)
        //{
        //    try
        //    {
        //        var idCreateProduct = controlPanelService.ProductionCreate(production);
        //        var message = Request.CreateResponse(HttpStatusCode.Created, idCreateProduct);
        //        message.Headers.Location = new Uri(Request.RequestUri + message.ToString());
        //        return message;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
            
        //}

        //public async Task<HttpResponseMessage> Delete(int id)
        //{
        //    try
        //    {
        //        bool checkDelete = controlPanelService.ProductionDelete(id);
        //        if (checkDelete)
        //        {
        //            var message = Request.CreateResponse(HttpStatusCode.OK, id);
        //            message.Headers.Location = new Uri(Request.RequestUri + message.ToString());
        //            return await Task.Run(() => message);
        //        }
        //        else
        //        {
        //            var message = Request.CreateResponse(HttpStatusCode.NotFound, id);
        //            message.Headers.Location = new Uri(Request.RequestUri + message.ToString());
        //            return await Task.Run(() => message);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return await Task.Run(() => Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex));
        //    }

        //}

        //public async Task<HttpResponseMessage> Put(int id,[FromBody] ProductionDTO production)
        //{
        //    try
        //    {
        //        var product = controlPanelService.GetProduction().FirstOrDefault(bd => bd.Id == id);

        //        if (product == null)
        //        {
        //            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Product with Id " + id.ToString());
        //        }
        //        else
        //        {
        //            product.Name = production.Name;
        //            product.Type = production.Type;
        //            product.Description = production.Description;
        //            product.FullName = production.FullName;
        //            if (controlPanelService.ProductionUpdate(product))
        //                return Request.CreateResponse(HttpStatusCode.OK, product);
        //            else
        //                return Request.CreateResponse(HttpStatusCode.BadRequest, product);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }

        //}


        //[System.Web.Http.HttpPost, System.Web.Http.Route("Create")]
        //public async void Create(ProductionDTO production)
        //{
        //    await Task.Run(() => controlPanelService.ProductionCreate(production));

        //}


    }
}