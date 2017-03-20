using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;
using capitaltoday2.CloudStorage.Acquisition;
using capitaltoday2.CloudStorage.Refinance;
using capitaltoday2.Helpers;

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
                //RefinanceClient tableStorage = new RefinanceClient();
                //tableStorage.Add(pRefinance);
                ////send email to user
                //string emailTemplate = EmailTemplateHelper.GetTemplate("Refinance");
                //string emailBody = string.Format(emailTemplate, pRefinance.Name);
                //EmailHelper.SendEmail(pRefinance.Email, "no-reply@CapitalToday.com", "Your Refinance Request Follow up", emailBody, true);
                ////send email to mortgage broker
                //string emailTemplate2 = EmailTemplateHelper.GetTemplate("RefinanceReferral");
                //string emailBody2 = string.Format(emailTemplate2, pRefinance.Name, pRefinance.LastName, pRefinance.Email, pRefinance.Phone, pRefinance.MarketValue, pRefinance.LoanBalance, pRefinance.PropertyType, pRefinance.UnitNumber, pRefinance.OtherDescription, pRefinance.PropertyState);
                //EmailHelper.SendEmail("olgasales@gmail.com ", "no-reply@CapitalToday.com", "New refinance request", emailBody2, true);
                ////EmailHelper.SendEmail("mike.mesheriakov@gmail.com ", "no-reply@CapitalToday.com", "New refinance request", emailBody2, true);
                ////EmailHelper.SendEmail("lrammairone@careercocorp.com", "no-reply@CapitalToday.com", "New refinance request", emailBody2, true);
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
                //AcquisitionClient tableStorage = new AcquisitionClient();
                //tableStorage.Add(pAcquisition);
                //string emailTemplate = EmailTemplateHelper.GetTemplate("Acquisition");
                //string emailBody = string.Format(emailTemplate, pAcquisition.Name);
                //EmailHelper.SendEmail(pAcquisition.Email, "no-reply@CapitalToday.com", "Your Loan Request Follow up", emailBody, true);
                ////send email to mortgage broker
                //string emailTemplate2 = EmailTemplateHelper.GetTemplate("AcquisitionReferral");
                //string emailBody2 = string.Format(emailTemplate2, pAcquisition.Name, pAcquisition.LastName, pAcquisition.Email, pAcquisition.Phone, pAcquisition.PurchasePrice, pAcquisition.RequestedLoanAmount, pAcquisition.PropertyType, pAcquisition.UnitNumber, pAcquisition.OtherDescription, pAcquisition.PropertyState);
                //EmailHelper.SendEmail("olgasales@gmail.com ", "no-reply@CapitalToday.com", "New loan request", emailBody2, true);
                ////EmailHelper.SendEmail("mike.mesheriakov@gmail.com ", "no-reply@CapitalToday.com", "New loan request", emailBody2, true);
                ////EmailHelper.SendEmail("lrammairone@careercocorp.com", "no-reply@CapitalToday.com", "New loan request", emailBody2, true);
                return Content(JsonConvert.SerializeObject(new { }), "application/json");
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound, ex.Message);
            }

        }

        public ActionResult Sandbox()
        {
            return View();
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