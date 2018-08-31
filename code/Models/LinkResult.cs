using Glass.Mapper.Sc.Fields;

namespace Sitecore.Foundation.Models.Models
{
    public class LinkResult
    {
        public string Anchor { get; set; }

        public string Text { get; set; }

        public string Query { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }

        public string Target { get; set; }

        public static LinkResult FromLink(Link link)
        {
            if (link == null)
                return null;

            return new LinkResult
            {
                Anchor = link.Anchor,
                Text = link.Text,
                Query = link.Query,
                Title = link.Title,
                Url = link.Url,
                Target = link.Target,
            };
        }
    }
}
