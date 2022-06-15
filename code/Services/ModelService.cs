using System.Collections.Concurrent;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using Sitecore.Web;

namespace Sitecore.Foundation.Models.Services
{
    public static class ModelService
    {
        const int _dictionaryConcurrencyLevel = 50; // When concurrency issue with regular dictionary was identified, there were ~40 threads in use so 50 is a guess at an appropriate number
        const int _dictionaryInitialSize = 10; // Unlikely to be more than 10 sites in a solution
        static ConcurrentDictionary<string, SitecoreService> _sitecoreServices
            = new ConcurrentDictionary<string, SitecoreService>(_dictionaryConcurrencyLevel, _dictionaryInitialSize);

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
