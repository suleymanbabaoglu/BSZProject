using System.Web.Optimization;

namespace MvcUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Js").Include(
                       "~/Scripts/jquery-3.2.1.min.js",
                       "~/Scripts/bootstrap.min.js",
                       "~/Scripts/jquery.slicknav.min.js",
                       "~/Scripts/owl.carousel.min.js",
                       "~/Scripts/jquery.nicescroll.min.js",
                       "~/Scripts/jquery.zoom.min.js",
                       "~/Scripts/jquery-ui.min.js",
                       "~/Scripts/main.js"
                       ));

            bundles.Add(new StyleBundle("~/Css").Include(
                       "~/Contents/css/bootstrap.min.css",
                       "~/Contents/css/slicknav.min.css",
                       "~/Contents/css/jquery-ui.min.css",
                       "~/Contents/css/owl.carousel.min.css",
                       "~/Contents/css/animate.css",
                       "~/Contents/css/style.css"));


            bundles.Add(new ScriptBundle("~/AdminJs").Include(
                        "~/Contents/AContent/bower_components/jquery/dist/jquery.js",
                        "~/Contents/AContent/bower_components/jquery-ui/jquery-ui.js",
                        "~/Contents/AContent/bower_components/bootstrap/dist/js/bootstrap.min.js",
                        "~/Contents/AContent/bower_components/jquery-slimscroll/jquery.slimscroll.min.js",
                        "~/Contents/AContent/bower_components/fastclick/lib/fastclick.js",
                        "~/Contents/AContent/bower_components/raphael/raphael.min.js",
                        "~/Contents/AContent/bower_components/morris.js/morris.min.js",
                        "~/Contents/AContent/bower_components/jquery-sparkline/dist/jquery.sparkline.min.js",
                        "~/Contents/AContent/bower_components/jquery-knob/dist/jquery.knob.min.js",
                        "~/Contents/AContent/bower_components/moment/min/moment.min.js",
                        "~/Contents/AContent/bower_components/bootstrap-daterangepicker/daterangepicker.js",
                        "~/Contents/AContent/bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js",
                        "~/Contents/AContent/plugins/jvectormap/jquery-jvectormap-1.2.2.min.js",
                        "~/Contents/AContent/plugins/jvectormap/jquery-jvectormap-world-mill-en.js",
                        "~/Contents/AContent/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                        "~/Contents/AContent/dist/js/adminlte.min.js",
                        "~/Contents/AContent/dist/js/pages/dashboard.js",
                        "~/Contents/AContent/dist/js/demo.js",
                        "~/Contents/AContent/bower_components/datatables.net/js/jquery.dataTables.min.js",
                        "~/Contents/AContent/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"
                        ));     
                         bundles.Add(new StyleBundle("~/AdminCss").Include(
                        "~/Contents/AContent/bower_components/bootstrap/dist/css/bootstrap.min.css",
                        "~/Contents/AContent/bower_components/Ionicons/css/ionicons.min.css",
                        "~/Contents/AContent/dist/css/AdminLTE.min.css",
                        "~/Contents/AContent/dist/css/skins/_all-skins.min.css",
                        "~/Contents/AContent/bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css",
                        "~/Contents/AContent/bower_components/bootstrap-daterangepicker/daterangepicker.css",
                        "~/Contents/AContent/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css",
                        "~/Contents/AContent/bower_components/morris.js/morris.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}