using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Models.Models.Interfaces
{
    [SitecoreType(TemplateId = Templates.File.ID_String)]
    public interface IFile : IBaseItem
    {
        [SitecoreField(Templates.File.Fields.Title_String)]
        string Title { get; set; }

        [SitecoreField(Templates.File.Fields.Keywords_String)]
        string Keywords { get; set; }

        [SitecoreField(Templates.File.Fields.Description_String)]
        string Description { get; set; }

        [SitecoreField(Templates.File.Fields.Extension_String)]
        string Extension { get; set; }

        [SitecoreField(Templates.File.Fields.MimeType_String)]
        string MimeType { get; set; }

        [SitecoreField(Templates.File.Fields.Size_String)]
        double? Size { get; set; }
    }
}
