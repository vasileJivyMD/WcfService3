using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Client.ServiceReferenceWeb;
using System.ServiceModel;
using System.IO;
using NLog;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ActionResult Index()
        {
            Service1Client client = new Service1Client();
            try
            {
                client.Open();
                int x = client.add(5, 9);
                ViewBag.X = x;
                ViewBag.Message = client.Message();
                return View();
            }
            catch (TimeoutException ex)
            {
                logger.Trace(ex.StackTrace);
                logger.Info(ex.Message);
                logger.Warn(ex.GetType());
          

                return null;
            }
            catch (FaultException ex)
            {
                logger.Trace(ex.StackTrace);
                logger.Info(ex.Message);
                logger.Warn(ex.GetType());


                return null;
            
            }
            catch (CommunicationException ex)
            {
                logger.Trace(ex.StackTrace);
                logger.Info(ex.Message);
                logger.Warn(ex.GetType());


                return null;
                
            }
            finally
            {

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
    }
}