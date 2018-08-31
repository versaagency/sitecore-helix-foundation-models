using System;
using Glass.Mapper.Sc.Fields;

namespace Sitecore.Foundation.Models.Models
{
    public class ImageResult
    {
        public string Alt { get; set; }

        public string Src { get; set; }

        public Guid MediaId { get; set; }

        public static ImageResult FromImage(Image image)
        {
            if (image == null)
                return null;

            return new ImageResult
            {
                Alt = image.Alt,
                Src = image.Src,
                MediaId = image.MediaId
            };
        }
    }
}
