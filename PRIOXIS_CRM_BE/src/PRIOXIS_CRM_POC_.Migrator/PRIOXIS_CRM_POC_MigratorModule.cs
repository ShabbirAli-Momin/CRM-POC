using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PRIOXIS_CRM_POC_.Configuration;
using PRIOXIS_CRM_POC_.EntityFrameworkCore;
using PRIOXIS_CRM_POC_.Migrator.DependencyInjection;

namespace PRIOXIS_CRM_POC_.Migrator
{
    [DependsOn(typeof(PRIOXIS_CRM_POC_EntityFrameworkModule))]
    public class PRIOXIS_CRM_POC_MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PRIOXIS_CRM_POC_MigratorModule(PRIOXIS_CRM_POC_EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PRIOXIS_CRM_POC_MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PRIOXIS_CRM_POC_Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PRIOXIS_CRM_POC_MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
