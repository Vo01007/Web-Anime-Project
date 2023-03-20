using System.Web;
using System.Web.Optimization;

namespace Project
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Styles
            bundles.Add(
                new StyleBundle("~/Content/all.min.css").Include("~/Content/style/all.min.css", new CssRewriteUrlTransform())
            );
            bundles.Add(
                new StyleBundle("~/Content/bootstrap.min.css").Include("~/Content/style/bootstrap.min.css", new CssRewriteUrlTransform())
            );
            bundles.Add(
                new StyleBundle("~/Content/owl.carousel.min.css").Include("~/Content/style/owl.carousel.min.css", new CssRewriteUrlTransform())
            );

            bundles.Add(new StyleBundle("~/Content/owl.theme.min.css").Include(
                     "~/Content/style/owl.theme.min.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/style.css").Include(
                     "~/Content/style/style.css",
            new CssRewriteUrlTransform()
                ));

            bundles.Add(new StyleBundle("~/Content/style.css.map").Include(
                     "~/Content/style/style.css.map",
            new CssRewriteUrlTransform()
                ));

            //Scripts

            bundles.Add(new Bundle("~/Scripts/bootstrap.bundle.min.js").Include(
                      "~/Scripts/scr/bootstrap.bundle.min.js"));

            bundles.Add(new Bundle("~/Scripts/jquery-3.2.1.min.js").Include(
                    "~/Scripts/scr/jquery-3.2.1.min.js"));

            bundles.Add(new Bundle("~/Scripts/jquery-scrolltofixed-min.js").Include(
                    "~/Scripts/scr/jquery-scrolltofixed-min.js"));

            bundles.Add(new Bundle("~/Scripts/owl.carousel.min.js").Include(
                    "~/Scripts/scr/owl.carousel.min.js"));

            bundles.Add(new Bundle("~/Scripts/script.js").Include(
                    "~/Scripts/scr/script.js"));
            bundles.Add(new Bundle("~/Scripts/popper.min.js").Include(
                    "~/Scripts/scr/popper.min.js"));
        }
    }
}
