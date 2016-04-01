using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    using System.Web.Optimization;
    using Manifest;

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Manifest()
        {
            var bundledResources = BundleTable.Bundles.Select(bundle => Scripts.Url(bundle.Path).ToString()).ToList();

            var manifestResult = new ManifestResultFile("2.4")
            {
                CacheResources = bundledResources,
                NetworkResources = new string[] { "*" },
                FallbackResources = { { "http://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.6/js/bootstrap.min.js", "/scripts/bootstrap.js" } }
            };
            return manifestResult;
        }
    }
}