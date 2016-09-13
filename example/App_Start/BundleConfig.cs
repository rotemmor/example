using System.Web;
using System.Web.Optimization;

namespace example
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
           "~/Content/bootstrap.css",
           "~/Content/site.css",
           "~/Content/bootstrap.min.css",
           "~/Content/font-awesome.css",
           "~/Content/font-awesome.min.css"
        ));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
          "~/Scripts/angular.min.js",
          "~/Scripts/angular-route.min.js",
          "~/Scripts/angular-file-upload.js",
          "~/Scripts/angular-file-upload.min.js"
       ));
             bundles.Add(new ScriptBundle("~/bundles/controllers").Include(
          "~/Scripts/Controllers/app.js",
          "~/Scripts/Controllers/directive.js",
          "~/Scripts/Controllers/service.js",
          "~/Scripts/Controllers/AddImageController.js",
          "~/Scripts/Controllers/ListController.js"
       ));


        }
    }
}
