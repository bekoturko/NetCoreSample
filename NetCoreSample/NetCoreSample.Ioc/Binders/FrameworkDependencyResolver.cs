using Autofac;
using NetCoreSample.Framework.Abstract;
using NetCoreSample.Framework.Services;

namespace NetCoreSample.Ioc.Binders
{
    public static class FrameworkDependencyResolver
    {
        public static void RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingService>().As<ILoggingService>().SingleInstance();
        }
    }
}