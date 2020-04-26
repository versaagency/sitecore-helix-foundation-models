using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data.Items;

namespace Sitecore.Foundation.Models.Models.Interfaces
{
    public interface IBaseItem
    {
        [SitecoreId]
        Guid Id { get; set; }

        [SitecoreField(Templates.BaseItem.Fields.WorkflowState_String)]
        Guid WorkflowState { get; set; }

        [SitecoreField(Templates.BaseItem.Fields.Workflow_String)]
        Guid Workflow { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url, UrlOptions = SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        string Url { get; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; set; }

        [SitecoreField(Templates.BaseItem.Fields.SortOrder_String)]
        int SortOrder { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }

        [SitecoreField(Templates.BaseItem.Fields.Updated_String)]
        DateTime Updated { get; set; }

        [SitecoreField(Templates.BaseItem.Fields.Created_String)]
        DateTime CreatedDate { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        string Language { get; set; }

        [SitecoreChildren]
        IEnumerable<IBaseItem> Children { get; set; }

        [SitecoreParent]
        IBaseItem Parent { get; set; }

        [SitecoreItem]
        Item Item { get; set; }

        string GetDisplayName();
    }
}
