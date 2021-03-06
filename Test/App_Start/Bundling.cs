﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.App_Start
{
    using System.Web.Optimization;

    public class Bundling
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            //Popular fallback expressions
            //lib               fallback expression
            //--------------------------------------
            //jQuery            window.jQuery
            //jQuery.UI         window.jQuery.ui
            //Modernizr         window.Modernizr
            //Bootstrap	        $.fn.modal

            var bundleItem = new ScriptBundle("~/bundles/jquery",
                "http://cdnjs.cloudflare.com/ajax/libs/jquery/1.10.2/jquery.min.js")
                .Include("~/Scripts/jquery-1.10.2.js");
            bundleItem.CdnFallbackExpression = "window.jQuery";
            bundles.Add(bundleItem);

            bundleItem = new ScriptBundle("~/bundles/bootstrap",
                "http://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.3.6/js/bootstrap.min.js")
                .Include("~/Scripts/bootstrap.js");
            bundleItem.CdnFallbackExpression = "$.fn.modal";
            bundles.Add(bundleItem);


            bundles.Add(new StyleBundle("~/bundles/bootstrapstyle", "http://ajax.aspnetcdn.com/ajax/bootstrap/3.3.6/css/bootstrap.min.css").Include(
                "~/Content/bootstrap.css"
                ));

            bundles.Add(new StyleBundle("~/bundles/localstyle").Include(
               "~/Content/Site.css"
               ));

            BundleTable.EnableOptimizations = true;
        }
    }
}