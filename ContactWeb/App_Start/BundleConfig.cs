using System.Web;
using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/js/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/js/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/js/lib/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/js/lib/jquery.dataTables.min.js",
                        "~/js/lib/dataTables.bootstrap.min.js",
                        "~/js/lib/dataTables.colReorder.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootswatch.bootstrap.min.css",
                      "~/css/colReorder.bootstrap.min.css",
                      "~/css/jquery-ui.min.css",
                      "~/css/Site.css")); // Use Site.css and never site.css otherwise boostrap.css cannot be overriden.
        }
    }
}
