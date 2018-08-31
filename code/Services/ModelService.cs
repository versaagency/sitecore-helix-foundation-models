using System.Collections.Generic;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Sitecore.Web;

namespace Sitecore.Foundation.Models.Services
{
    public static class ModelService
    {
        static Dictionary<string, SitecoreService> _sitecoreServices = new Dictionary<string, SitecoreService>();

        public static SitecoreService SitecoreService
            => GetSitecoreService(Context.Site.SiteInfo);

        public static SitecoreService GetSitecoreService()
        {
            return GetSitecoreService(Context.Site.SiteInfo);
        }

        public static SitecoreService GetSitecoreService(SiteInfo site)
        {
            if (!_sitecoreServices.ContainsKey(site.Name) || _sitecoreServices[site.Name] == null)
            {
                _sitecoreServices[site.Name] = new SitecoreService(site.Database);
            }

            return _sitecoreServices[site.Name];
        }

        public static T As<T>(this Item item)
            where T : class => SitecoreService.Cast<T>(item);
    }
}
