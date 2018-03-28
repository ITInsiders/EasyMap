using System.Web;
using System.Web.Optimization;

namespace EM
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/bundles/SystemStyles").Include(
                "~/Content/bootstrap*"
                ));

            bundles.Add(new ScriptBundle("~/bundles/SystemScripts").Include(
                "~/Scripts/modernizr-{version}.js",
                "~/Scripts/respond*",
                "~/Scripts/jquery*",
                "~/Scripts/popper*",
                "~/Scripts/bootstrap*"
                ));



            bundles.Add(new ScriptBundle("~/bundles/signalr").Include(
                        "~/Scripts/jquery.signalR-2.2.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/DefaultStyles").Include(
                "~/Fonts/Font.css", "~/Content/bootstrap.min.css", "~/Assets/CSS/noty.css",
                "~/Assets/CSS/Main.css"
                ));

            bundles.Add(new ScriptBundle("~/DefaultScrits").Include(
                "~/Scripts/modernizr-*", "~/Scripts/respond.js",
                "~/Assets/JS/noty.min.js", "~/Assets/JS/Main.js"
                ));

            bundles.Add(new StyleBundle("~/CSS/Index").Include(
                "~/Assets/CSS/Index.css"));

            bundles.Add(new ScriptBundle("~/JS/Index").Include(
                "~/Assets/JS/Index.js"));

            bundles.Add(new StyleBundle("~/CSS/Search").Include(
                "~/Assets/CSS/Search.css"));

            bundles.Add(new ScriptBundle("~/JS/Search").Include(
                "~/Assets/JS/Search.js"));

            bundles.Add(new StyleBundle("~/CSS/AddPlace").Include(
                "~/Assets/CSS/AddPlace.css"));

            bundles.Add(new ScriptBundle("~/JS/AddPlace").Include(
                "~/Assets/JS/AddPlace.js"));

        }
    }
}
