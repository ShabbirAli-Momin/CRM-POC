using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PRIOXIS_CRM_POC_.Configuration;

namespace PRIOXIS_CRM_POC_.Web.Host.Startup
{
    [DependsOn(
       typeof(PRIOXIS_CRM_POC_WebCoreModule))]
    public class PRIOXIS_CRM_POC_WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PRIOXIS_CRM_POC_WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PRIOXIS_CRM_POC_WebHostModule).GetAssembly());
        }
    }
}
