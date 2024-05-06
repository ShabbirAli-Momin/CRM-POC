using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PRIOXIS_CRM_POC_.EntityFrameworkCore;
using PRIOXIS_CRM_POC_.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace PRIOXIS_CRM_POC_.Web.Tests
{
    [DependsOn(
        typeof(PRIOXIS_CRM_POC_WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class PRIOXIS_CRM_POC_WebTestModule : AbpModule
    {
        public PRIOXIS_CRM_POC_WebTestModule(PRIOXIS_CRM_POC_EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PRIOXIS_CRM_POC_WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PRIOXIS_CRM_POC_WebMvcModule).Assembly);
        }
    }
}