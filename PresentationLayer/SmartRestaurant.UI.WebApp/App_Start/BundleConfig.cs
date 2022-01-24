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
                        "~/Scripts/jquery-{version}.js"
                        , "~/Content/Theme/dist/plugins/summernote/toastr.min.js"
                        ));

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
                      "~/Content/bootstrap.css",
                      "~/Content/Theme/dist/css/adminlte.min.css",
                      "~/Content/Theme/dist/plugins/fontawesome-free/css/all.min.css",
                      "~/Content/Theme/dist/plugins/summernote/summernote-bs4.min.css",
                      "~/Content/site.css",
                      "~/Content/toastr.css"
                      ));

            bundles.Add(new ScriptBundle("~/adminlte/js").Include(
             "~/Content/Theme/dist/js/adminlte.min.js",
             "~/Content/Theme/dist/plugins/summernote/summernote-bs4.min.js",
             "~/Scripts/toastr.js*",
             "~/Scripts/toastrImp.js"
             ));

            //Added for toaster
            //bundles.Add(new ScriptBundle("~/bundles/toastr").Include(
            //           "~/Scripts/toastr.js*",
            //           "~/Scripts/toastrImp.js"));
        }

        public static void RegisterBundles_1(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/scripts/adminlte").Include(
                 //"~/Scripts/jquery-{version}.js"
                 //, "~/Scripts/jquery-3.4.1.min.js"
                 //, "~/Scripts/jquery-migrate-3.0.0.min.js,               

                 "~/Content/Theme/plugins/jqvmap/jquery.vmap.min.js"
                , "~/Content/Theme/plugins/jqvmap/maps/jquery.vmap.usa.js"
                , "~/Content/Theme/plugins/jquery-knob/jquery.knob.min.js"
                , "~/Content/Theme/plugins/moment/moment.min.js"
                , "~/Content/Theme/plugins/bootstrap/js/bootstrap.bundle.min.js"
                , "~/Content/Theme/plugins/chart.js/Chart.min.js"
                , "~/Content/Theme/plugins/sparklines/sparkline.js"
                , "~/Content/Theme/plugins/daterangepicker/daterangepicker.js"
                , "~/Content/Theme/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js"
                , "~/Content/Theme/plugins/summernote/summernote-bs4.min.js"
                , "~/Content/Theme/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js"
                , "~/Content/Theme/dist/js/adminlte.js"
                , "~/Content/Theme/dist/js/demo.js"
                , "~/Content/Theme/dist/js/pages/dashboard.js"
                //, "~/Content/Theme/plugins/toastr/toastr.min.js"
                , "~/scripts/jquery.validate.min.js"
                , "~/Scripts/jquery.validate.unobtrusive.js"
                , "~/Scripts/jquery.blockUI.js"

                //, "~/Scripts/jquery-3.4.1.js"
                ));


            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        //"~/Content/Theme/plugins/jquery/jquery.min.js"
                        "~/Scripts/jquery-3.4.1.js"
                        , "~/Scripts/jquery-{version}.js"
                        , "~/Content/Theme/plugins/jquery-ui/jquery-ui.min.js"
                        //, "~/Scripts/jquery-migrate-3.0.0.min.js"
                        ));


            //bundles.Add(new StyleBundle("~/content/adminlte").IncludeDirectory("~/content/Theme/plugins", "*.css"));
            bundles.Add(new StyleBundle("~/content/adminlte").Include(
                "~/Content/Theme/plugins/fontawesome-free/css/all.min.css",
                "~/Content/Theme/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                "~/Content/Theme/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                //"~/Content/Theme/plugins/jqvmap/jqvmap.min.css",
                "~/Content/Theme/dist/css/adminlte.min.css",
                "~/Content/Theme/plugins/overlayScrollbars/css/OverlayScrollbars.min.css"
                , "~/Content/Theme/plugins/daterangepicker/daterangepicker.css"
                , "~/Content/Theme/plugins/summernote/summernote-bs4.min.css"
                //, "~/Content/Theme/plugins/toastr/toastr.min.css"
                ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //          "~/Scripts/bootstrap.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));
        }
    }
}
