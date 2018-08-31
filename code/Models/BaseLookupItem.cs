using System;
using Sitecore.Data.Items;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Foundation.Models.Models
{
    public class BaseLookupItem
    {
        public virtual Guid Id { get; set; }

        public string Name { get; set; }

        public static BaseLookupItem FromItem(Item item)
        {
            return new BaseLookupItem()
            {
                Id = item.ID.Guid,
                Name = item.Name,
            };
        }

        public static BaseLookupItem FromItem(IBaseItem item)
        {
            return new BaseLookupItem()
            {
                Id = item.Id,
                Name = item.Name,
            };
        }
    }
}
