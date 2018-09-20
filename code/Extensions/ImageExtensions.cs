using System;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Items;

namespace Sitecore.Foundation.Models.Extensions
{
    public static class ImageExtensions
    {
        public static Item Item(this Image image)
        {
            if (image == null)
            {
                throw new ArgumentNullException(nameof(image));
            }

            var context = new SitecoreContext();
            return context.GetItem<Item>(image.MediaId);
        }
    }
}
