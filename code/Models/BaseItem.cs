using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Foundation.Models.Models
{
    public class BaseItem : IBaseItem
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField("__Workflow state")]
        public virtual Guid WorkflowState { get; set; }

        [SitecoreField("__Workflow")]
        public virtual Guid Workflow { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        public virtual string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        public virtual string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; set; }

        [SitecoreField("__Sortorder")]
        public virtual int SortOrder { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }

        [SitecoreField("__Updated")]
        public virtual DateTime Updated { get; set; }

        [SitecoreField("__Created")]
        public virtual DateTime CreatedDate { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<IBaseItem> Children { get; set; }

        [SitecoreParent]
        public IBaseItem Parent { get; set; }

        public virtual string GetDisplayName()
            => string.IsNullOrWhiteSpace(DisplayName) ? Name : DisplayName;
    }
}
