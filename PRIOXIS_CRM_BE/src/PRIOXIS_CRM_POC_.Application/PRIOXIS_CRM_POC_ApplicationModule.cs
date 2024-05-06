using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PRIOXIS_CRM_POC_.Authorization;

namespace PRIOXIS_CRM_POC_
{
    [DependsOn(
        typeof(PRIOXIS_CRM_POC_CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PRIOXIS_CRM_POC_ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PRIOXIS_CRM_POC_AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PRIOXIS_CRM_POC_ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
