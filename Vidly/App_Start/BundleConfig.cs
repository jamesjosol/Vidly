using System.Web;
using System.Web.Optimization;

namespace Vidly
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/lib").Include(
                "~/Scripts/latestjquery.min.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/bootbox.all.min.js",
                "~/Scripts/datatables/jquery.datatables.js",
                "~/Scripts/datatables/dataTables.bootstrap5.min.js",
                "~/Scripts/typeahead.bundle.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/latestjquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/script").Include(
                "~/Scripts/script.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));


            bundles.Add(new ScriptBundle("~/bundles/bootstrapmin").Include(
                "~/Scripts/bootstrap.min.js"));

            bundles.Add(new Bundle("~/bundles/bootstrapbundle").Include(
                "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootboxv6.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootbox").Include(
                "~/Scripts/bootbox.all.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/customerIndex").Include(
                "~/Scripts/customerIndex.js"));


            bundles.Add(new ScriptBundle("~/bundles/movieIndex").Include(
                "~/Scripts/movieIndex.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/fontawesome-6.2.1/css/all.min.css",
                "~/Content/bootstrap-yeti.css",
                "~/Content/datatables/css/dataTables.bootstrap5.min.css",
                "~/Content/typeahead.css",
                "~/Content/site.css"));


        }
    }
}