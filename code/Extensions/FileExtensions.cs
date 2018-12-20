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
    }
}
