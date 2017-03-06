using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;
using capitaltoday2.CloudStorage.Acquisition;
using capitaltoday2.CloudStorage.Refinance;

namespace capitaltoday2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult submitRefinanceAccount(Refinance pRefinance)
        {

            try
            {
                RefinanceClient tableStorage = new RefinanceClient();
                tableStorage.Add(pRefinance);
                return Content(JsonConvert.SerializeObject(new { }), "application/json");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, ex.Message);
            }

        }

        [HttpPost]
        public ActionResult submitAcquisitionAccount(Acquisition pAcquisition)
        {
            try
            {
                AcquisitionClient tableStorage = new AcquisitionClient();
                tableStorage.Add(pAcquisition);
                return Content(JsonConvert.SerializeObject(new { }), "application/json");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, ex.Message);
            }

        }

        public ActionResult DeleteRefinanceAccounts()
        {
            try
            {
                RefinanceClient tableStorage = new RefinanceClient();
                tableStorage.DeleteTable();
                return Content(JsonConvert.SerializeObject(new { }), "application/json");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, ex.Message);
            }
        }
        public ActionResult DeleteAcquisitionAccounts()
        {
            try
            {
                AcquisitionClient tableStorage = new AcquisitionClient();
                tableStorage.DeleteTable();
                return Content(JsonConvert.SerializeObject(new { }), "application/json");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, ex.Message);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Dashboard";
            return View();
        }
    }
}