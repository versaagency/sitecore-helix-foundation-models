using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Fields;
using Sitecore.Foundation.Models.Models.Interfaces;

namespace Sitecore.Foundation.Models.Extensions
{
    public static class FileExtensions
    {
        public static string FriendlySize(this IFile file)
        {
            if (file == null)
            {
                throw new System.ArgumentNullException(nameof(file));
            }

            if (!file.Size.HasValue)
            {
                return string.Empty;
            }

            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = file.Size.Value;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }

            return string.Format("{0:0.#} {1}", len, sizes[order]);
        }

        public static IFile GetIFile(this File file)
        {
            return GetIFile(file, new SitecoreContext());
        }

        public static IFile GetIFile(this File file, ISitecoreContext context)
        {
            if (file == null)
            {
                throw new System.ArgumentNullException(nameof(file));
            }

            return context.GetItem<IFile>(file.Id);
        }
    }
}
