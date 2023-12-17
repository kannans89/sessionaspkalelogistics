using LayoutFromScractchApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LayoutFromScractchApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetDataNonBlocking()
        {

            var beforeThead = Thread.CurrentThread.ManagedThreadId;
            await Task.Run(() =>
              {
                  Thread.Sleep(5 * 1000);


              });
            var afterThead = Thread.CurrentThread.ManagedThreadId;
            var response = new
            {
                BeforeThreadId = beforeThead,
                AfterThreadId = afterThead,
                Message = "Hello from GetDataAsync"
            };

            return Json(response);

        }

        public IActionResult GetDataBlocking()
        {

            var beforeThead = Thread.CurrentThread.ManagedThreadId;
           
         
                Thread.Sleep(5 * 1000);


          
            var afterThead = Thread.CurrentThread.ManagedThreadId;
            var response = new
            {
                BeforeThreadId = beforeThead,
                AfterThreadId = afterThead,
                Message = "Hello from GetData"
            };

            return Json(response);

        }

        public IActionResult GetPartialView()
        {

            return PartialView("_timestamp", new TimeStampModel { Title = "Time via Ajax", Format = "hh:mm:ss" });
        }
    }
}
