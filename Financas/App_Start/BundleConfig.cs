using System.Web;
using System.Web.Optimization;

namespace Financas
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new StyleBundle("~/bundles/style")
                    .Include("~/Content/vendor/bootstrap/css/bootstrap.css")
                    .Include("~/Content/vendor/fontawesome-free/css/all.css")
                    .Include("~/Content/css/sb-admin-2.css")
            );

            bundles.Add(
                new ScriptBundle("~/bundles/script")
                    .Include("~/Content/vendor/jquery/jquery.js")
                    .Include("~/Content/vendor/jquery/jquery.validate.js")
                    .Include("~/Content/vendor/jquery/jquery.unobtrusive-ajax.js")
                    .Include("~/Content/vendor/jquery/jquery.validate.unobtrusive.js")
                    .Include("~/Content/vendor/jquery/jquery.validate-vsdoc.js")
                    .Include("~/Content/vendor/bootstrap/js/bootstrap.js")
            );

            bundles.Add(
                new StyleBundle("~/bundles/style/datatable")
                    .Include("~/Content/vendor/datatables/dataTables.bootstrap4.css")
            );

            bundles.Add(
                new ScriptBundle("~/bundles/script/datatable")
                    .Include("~/Content/vendor/datatables/jquery.dataTables.js")
                    .Include("~/Content/vendor/datatables/dataTables.bootstrap4.js")
            );
        }
    }
}
