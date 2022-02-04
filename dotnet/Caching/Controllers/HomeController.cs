using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using Caching.Models;

namespace Caching.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMemoryCache memoryCache;

        public HomeController(IMemoryCache memoryCache)
        {
          this.memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
          DateTime currentTime;
          bool isExits = memoryCache.TryGetValue("CacheTime", out currentTime);
          if(!isExits)
          {
            currentTime = DateTime.Now;
            var cacheEntryOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(30));
            memoryCache.Set("CacheTime", currentTime, cacheEntryOptions);
          }
          return View(currentTime);
        }

        public IActionResult RemoveCache(){
          memoryCache.Remove("CacheTime");
          DateTime? currentTime = memoryCache.Get<DateTime?>("CacheTime");
          return View("Index", currentTime);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
