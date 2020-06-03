using System.Web;
using System.Web.Optimization;

namespace telebachillerato
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información. De este modo, estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js", "~/Scripts/Content/js/bootstrap.min.js", "~/Scripts/Content/js/jquery-1.11.2.min.js", "~/Scripts/Content/js/main.js", "~/Scripts/Content/js/modernizr.js",
                      "~/Scripts/Content/js/sb-admin-2.js", "~/Scripts/Content/js/sb-admin-2.min.js", "~/Scripts/Content/js/demo/chart-area-demo.js", "~/Scripts/Content/js/demo/chart-bar-demo.js",
                      "~/Scripts/Content/js/demo/chart-pie-demo.js", "~/Scripts/Content/js/demo/datatables-demo.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css", "~/Content/css/bootstrap.min.css", "~/Content/css/font-awesome.min.css", "~/Content/css/normalize.css", "~/Content/css/sb-admin-2.css", "~/Content/css/sb-admin-2.min.css",
                      "~/Content/css/style.css"));
        }
    }
}
