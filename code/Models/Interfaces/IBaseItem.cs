using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Models.Models.Interfaces
{
    public interface IBaseItem
    {
        Guid Id { get; set; }

        Guid TemplateId { get; set; }

        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        string Url { get; }

        string Path { get; set; }

        string DisplayName { get; set; }

        [SitecoreField("__Sortorder")]
        int SortOrder { get; set; }

        string Name { get; set; }

        [SitecoreField("__Updated")]
        DateTime Updated { get; set; }

        [SitecoreField("__Created")]
        DateTime CreatedDate { get; set; }

        [SitecoreChildren]
        IEnumerable<IBaseItem> Children { get; set; }

        [SitecoreParent]
        IBaseItem Parent { get; set; }

        string GetDisplayName();
    }
}
