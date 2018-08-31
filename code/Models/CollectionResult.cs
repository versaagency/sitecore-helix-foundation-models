using System.Collections.Generic;

namespace Sitecore.Foundation.Models.Models
{
    public class CollectionResult<T>
        where T : new()
    {
        public CollectionResult()
        {
        }

        public IEnumerable<T> Items { get; set; }

        public int Total { get; set; }

        public int Offset { get; set; }

        public bool HasMore { get; set; }
    }
}
