using Autofac;
using NetCoreSample.Framework.Abstract;
using NetCoreSample.Framework.Services;
using NetCoreSample.Framework.Wrappers;

namespace NetCoreSample.Ioc.Binders
{
    public static class FrameworkDependencyResolver
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            // SingleInstance
            builder.RegisterType<LoggingService>().As<ILoggingService>().SingleInstance();
            builder.RegisterType<SettingsReader>().As<ISettingsReader>().SingleInstance();
            builder.RegisterType<ConfigurationManagerWrapper>().As<IConfigurationManager>().SingleInstance();

            // InstancePerLifetimeScope
            builder.RegisterType<Settings>().As<ISettings>().InstancePerLifetimeScope();
        }
    }
}