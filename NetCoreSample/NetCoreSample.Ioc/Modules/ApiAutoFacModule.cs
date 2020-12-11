using Autofac;
using Microsoft.Extensions.Configuration;
using NetCoreSample.Ioc.Binders;

namespace NetCoreSample.Ioc.Modules
{
    public class ApiAutoFacModule : Module
    {
        #region ctor

        readonly IConfiguration configuration;

        public ApiAutoFacModule(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #endregion

        protected override void Load(ContainerBuilder builder)
        {
            FrameworkDependencyResolver.RegisterServices(builder);
        }
    }
}