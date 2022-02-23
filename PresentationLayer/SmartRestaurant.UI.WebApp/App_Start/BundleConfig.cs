using System.Web;
using System.Web.Optimization;

namespace SmartRestaurant.UI.WebApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Content/Theme/plugins/jquery-ui/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.bundle.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
               "~/Content/Theme/plugins/fontawesome-free/css/all.min.css",
               "~/Content/Theme/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
               "~/Content/Theme/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
               //"~/Content/Theme/plugins/jqvmap/jqvmap.min.css",
               "~/Content/Theme/dist/css/adminlte.min.css",
               "~/Content/Theme/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
               "~/Content/Theme/plugins/daterangepicker/daterangepicker.css",
               "~/Content/Theme/plugins/summernote/summernote-bs4.min.css",
               "~/Content/Theme/plugins/bootstrap-colorpicker/css/bootstrap-colorpicker.min.css",
               "~/Content/Theme/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css",
               "~/Content/Theme/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css",
                "~/Content/Theme/plugins/datatables-responsive/css/responsive.bootstrap4.min.css",
                "~/Content/Theme/plugins/datatables-buttons/css/buttons.bootstrap4.min.css",
               //"~/Content/site.css",
               //"~/Content/bootstrap.css",
               "~/Content/toastr.css"
                     ));

            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
             "~/Content/Theme/plugins/jquery/jquery.min.js",
             "~/Content/Theme/plugins/jquery-ui/jquery-ui.min.js",

             "~/Content/Theme/plugins/bootstrap/js/bootstrap.bundle.min.js",
             "~/Content/Theme/plugins/chart.js/Chart.min.js",
             "~/Content/Theme/plugins/sparklines/sparkline.js",
             //"~/Content/Theme/plugins/jqvmap/jquery.vmap.min.js",
             //"~/Content/Theme/plugins/jqvmap/maps/jquery.vmap.usa.js",
             "~/Content/Theme/plugins/jquery-knob/jquery.knob.min.js",
             "~/Content/Theme/plugins/moment/moment.min.js",
             "~/Content/Theme/plugins/daterangepicker/daterangepicker.js",
             "~/Content/Theme/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
             "~/Content/Theme/plugins/summernote/summernote-bs4.min.js",
             "~/Content/Theme/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
            // DataTables & Plugins
            "~/Content/Theme/plugins/datatables/jquery.dataTables.min.js",
            "~/Content/Theme/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
            "~/Content/Theme/plugins/datatables-responsive/js/dataTables.responsive.min.js",
            "~/Content/Theme/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
            "~/Content/Theme/plugins/datatables-buttons/js/dataTables.buttons.min.js",
            "~/Content/Theme/plugins/datatables-buttons/js/buttons.bootstrap4.min.js",
            "~/Content/Theme/plugins/jszip/jszip.min.js",
            "~/Content/Theme/plugins/pdfmake/pdfmake.min.js",
            "~/Content/Theme/plugins/pdfmake/vfs_fonts.js",
            "~/Content/Theme/plugins/datatables-buttons/js/buttons.html5.min.js",
            "~/Content/Theme/plugins/datatables-buttons/js/buttons.print.min.js",
            "~/Content/Theme/plugins/datatables-buttons/js/buttons.colVis.min.js",

             "~/Content/Theme/dist/js/adminlte.js",
             "~/Content/Theme/dist/js/demo.js",
             "~/Scripts/toastr.js*",
             "~/Scripts/toastrImp.js",
             "~/Content/Theme/dist/js/pages/dashboard.js"
             ));
            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
