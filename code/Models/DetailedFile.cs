using Glass.Mapper.Sc.Configuration.Attributes;

namespace Sitecore.Foundation.Models.Models.Interfaces
{
    // This class is needed as the concrete version of IFile.
    [SitecoreType(TemplateId = Templates.File.ID_String)]
    public class DetailedFile : BaseItem, IFile
    {
        [SitecoreField(Templates.File.Fields.Title_String)]
        public string Title { get; set; }

        [SitecoreField(Templates.File.Fields.Keywords_String)]
        public string Keywords { get; set; }

        [SitecoreField(Templates.File.Fields.Description_String)]
        public string Description { get; set; }

        [SitecoreField(Templates.File.Fields.Extension_String)]
        public string Extension { get; set; }

        [SitecoreField(Templates.File.Fields.MimeType_String)]
        public string MimeType { get; set; }

        [SitecoreField(Templates.File.Fields.Size_String)]
        public double? Size { get; set; }
    }
}
