using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace CodeTestAPI.Controllers
{
   
    [RoutePrefix("Api/CodeTest")]
    public class CodeTestController : Controller
    {
        // GET: CodeTest
        public ActionResult Index()
        {
            return View();
        }
        
        [Route("GetProductById")]
        [HttpGet]
        public string GetProductById(int id)
        {
            if (id==1)
            {
                return "MILK";
            }
            else if(id==2)
            {
                return "ORANGE";
            }
            else
            {
                return "INVALID PROD TP";
            }
        }
    }
}