using Glass.Mapper.Configuration;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Sc.IoC;
using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

namespace Sitecore.Project.Common.App_Start
{
    public static class GlassMapperScCustom
    {
        public static IDependencyResolver CreateResolver()
        {
            var config = new Glass.Mapper.Sc.Config();

            var dependencyResolver = new DependencyResolver(config);

            dependencyResolver.Finalise();

            return dependencyResolver;
        }

        public static IConfigurationLoader[] GlassLoaders()
        {
            return new IConfigurationLoader[] { };
        }

        public static void PostLoad(IDependencyResolver dependencyResolver)
        {
        }

        public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
        {
        }
    }
}
