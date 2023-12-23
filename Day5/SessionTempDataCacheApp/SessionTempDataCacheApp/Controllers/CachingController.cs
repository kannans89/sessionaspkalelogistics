using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace SessionTempDataCacheApp.Controllers
{
    public class CachingController:Controller
    {
        private readonly IMemoryCache _memoryCache;
        public CachingController(IMemoryCache cache) { 
        
         _memoryCache = cache;
        }

        [ResponseCache(Duration = 5)]
        public IActionResult Test()
        {
            string time = DateTime.Now.ToLocalTime().ToString();
            return Content($"<h1>time is {time}</h1>", "text/html");
        }


        public IActionResult Index()
        {
            //int result = 0;
            //if (!int.TryParse("abcd", out result)) {
            //    Console.WriteLine("couldt parse values");
            //    retrun;
            //}
            //Console.WriteLine(result);


            string time = null;
            if (!_memoryCache.TryGetValue("time", out time))
            {

                time = DateTime.Now.ToLocalTime().ToString();
                _memoryCache.Set("time", time,

                 new MemoryCacheEntryOptions()
                 {
                     AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(5)

                     // AbsoluteExpirationRelativeToNow = (DateTime.Now.AddSeconds(5) - DateTime.Now)
                 });
            }

            ViewBag.time = time;


            return View();
        }
    }
}
