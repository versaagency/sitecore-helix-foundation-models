using Glass.Mapper.Sc;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.Foundation.Models.Models.Interfaces;
using Sitecore.Foundation.SitecoreExtensions.Extensions;

namespace Sitecore.Foundation.Models.Extensions
{
    public static class IBaseItemExtensions
    {
        /// <summary>
        /// This is a wrapper for IBaseItem, for the IsDerived method.
        /// </summary>
        /// <param name="baseItem"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public static bool IsDerived(this IBaseItem baseItem, ID templateId)
        {
            var context = new SitecoreContext();
            var item = context.GetItem<Item>(baseItem.Id);
            return item.IsDerived(templateId);
        }
    }
}
