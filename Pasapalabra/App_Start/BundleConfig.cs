using System.Web;
using System.Web.Optimization;

namespace Pasapalabra
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            // Javascript dependencies
            bundles.Add(new ScriptBundle("~/bundles/library").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // CSS dependencies
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/main.css"));
        }
    }
}
