using System.Web;
using System.Web.Optimization;

namespace HopDongCSHT
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                 "~/Assets/bower_components/jquery/dist/jquery.js",
                       "~/Assets/bower_components/jquery-ui/jquery-ui.min.js",
                       "~/Assets/bower_components/bootstrap/dist/js/bootstrap.min.js",
                       "~/Assets/bower_components/moment/min/moment.min.js",
                        "~/Scripts/jquery.validate.js",
                         "~/Scripts/jquery.validate.unobtrusive.js",
                       "~/Assets/bower_components/datatables/datatables.min.js",
                         "~/Assets/bower_components/Auto-Format/simple.money.format.js",
                       "~/Assets/bower_components/raphael/raphael.min.js",
                       "~/Assets/bower_components/morris.js/morris.min.js",
                       "~/Assets/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                       "~/Assets/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                       "~/Assets/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                       "~/Assets/bower_components/jquery-knob/dist/jquery.knob.min.js",
                       "~/Assets/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                       "~/Assets/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                       "~/Assets/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                       "~/Assets/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                       "~/Assets/bower_components/fastclick/lib/fastclick.js",
                       "~/Assets/dist/js/adminlte.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/custom-validator").Include(
                                 "~/Scripts/script-custom-validator.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Assets/bower_components/bootstrap/dist/css/bootstrap.min.css",
                      //"~/Content/bootstrap.css",
                      "~/Assets/bower_components/font-awesome/css/font-awesome.min.css",
                      "~/Assets/bower_components/Ionicons/css/ionicons.min.css",
                      "~/Assets/bower_components/datatables/datatables.min.css",
                      "~/Assets/dist/css/AdminLTE.min.css",
                      "~/Assets/dist/css/skins/_all-skins.min.css",
                      "~/Assets/bower_components/morris.js/morris.css",
                      "~/Assets/bower_components/jvectormap/jquery-jvectormap.css",
                      "~/Assets/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                      "~/Assets/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                      "~/Assets/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                      "~/Content/site.css"));
        }
    }
}
