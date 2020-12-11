using Autofac;
using Microsoft.Extensions.Hosting;
using NetCoreSample.Ioc.Modules;

namespace NetCoreSample.Ioc
{
    public static class AutofacContainerConfigurator
    {
        public static void ConfigureContainer(HostBuilderContext context, ContainerBuilder builder)
        {
            builder.RegisterModule(new ApiAutoFacModule(context.Configuration));
        }
    }
}