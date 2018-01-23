using System.Web;
using System.Web.Optimization;

namespace EM
{
    public class BundleConfig
    {
        // Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/signalr").Include(
                        "~/Scripts/jquery.signalR-2.2.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.3.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/CSS/Main").Include(
                        "~/Assets/JS/Main.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
                        "~/Content/bootstrap.min.css"));

            bundles.Add(new StyleBundle("~/JS/Main").Include(
                        "~/Fonts/Font.css",
                        "~/Assets/CSS/Main.css"));
        }
    }
}
