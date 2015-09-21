﻿using System.Web;
using System.Web.Optimization;

namespace CustomerDetails
{
    public class BundleConfig
    {
       
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));                             

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                       "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                                      "~/Content/bootstrap-theme.css",
                                      "~/Content/bootstrap.css"));
        }
    }
}