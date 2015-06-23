using System.Web;
using System.Web.Optimization;

namespace PhoneStore.Web
{
    public class BundleConfig
    {
        // For more information on bundling/ visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/js_common").Include(
          "~/Scripts/theme/easing.js", 
          //"~/Scripts/theme/jquery.min.js",
          "~/Scripts/theme/jquery.mmenu.js",
          "~/Scripts/theme/move-top.js" 
          ));

            bundles.Add(new ScriptBundle("~/bundles/slideshow").Include(
                "~/Scripts/theme/jquery.eislideshow.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/cloudzoom").Include(
                "~/Scripts/theme/cloud-zoom.1.0.3.min.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/fancybox").Include(
                "~/Scripts/theme/jquery.fancybox.pack.js"
            ));

            bundles.Add(new ScriptBundle("~/viewgallery").Include(
                "~/Scripts/theme/productviewgallery.js"
            ));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css_common").Include(
            "~/Content/theme/jquery.mmenu.all.css",
            "~/Content/theme/style.css"
            ));

            bundles.Add(new StyleBundle("~/Content/slider").Include(
                "~/Content/theme/slider.css"
                ));

            bundles.Add(new StyleBundle("~/Content/viewgallery").Include(
                "~/Content/theme/productviewgallery.css"
            ));
        }
    }
}
