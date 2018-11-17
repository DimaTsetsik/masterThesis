using System.Web;
using System.Web.Optimization;

namespace FFilms
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            //bundles.Add(new ScriptBundle("~/ThemeScripts").Include(
            //          "~/ThemeStyles/js/jquery/jquery-2.2.4.min.js",
            //          "~/ThemeStyles/js/bootstrap/popper.min.js",
            //          "~/ThemeStyles/js/bootstrap/bootstrap.min.js",
            //          "~/ThemeStyles/js/bootstrap/plugins.js",
            //          "~/ThemeStyles/js/bootstrap//active.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //bundles.Add(new StyleBundle("~/ThemeStyles")
            //    .Include("~/ThemeStyles/style.css"));
        }
    }
}