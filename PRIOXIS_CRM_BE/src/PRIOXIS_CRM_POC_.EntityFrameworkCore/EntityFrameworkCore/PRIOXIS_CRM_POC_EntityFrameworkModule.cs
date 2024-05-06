using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using PRIOXIS_CRM_POC_.EntityFrameworkCore.Seed;

namespace PRIOXIS_CRM_POC_.EntityFrameworkCore
{
    [DependsOn(
        typeof(PRIOXIS_CRM_POC_CoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class PRIOXIS_CRM_POC_EntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<PRIOXIS_CRM_POC_DbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        PRIOXIS_CRM_POC_DbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        PRIOXIS_CRM_POC_DbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PRIOXIS_CRM_POC_EntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
