using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Runtime.Security;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using PRIOXIS_CRM_POC_.Authorization.Roles;
using PRIOXIS_CRM_POC_.Authorization.Users;
using PRIOXIS_CRM_POC_.Configuration;
using PRIOXIS_CRM_POC_.Localization;
using PRIOXIS_CRM_POC_.MultiTenancy;
using PRIOXIS_CRM_POC_.Timing;

namespace PRIOXIS_CRM_POC_
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class PRIOXIS_CRM_POC_CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            PRIOXIS_CRM_POC_LocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = PRIOXIS_CRM_POC_Consts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
            
            Configuration.Localization.Languages.Add(new LanguageInfo("fa", "فارسی", "famfamfam-flags ir"));
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = PRIOXIS_CRM_POC_Consts.DefaultPassPhrase;
            SimpleStringCipher.DefaultPassPhrase = PRIOXIS_CRM_POC_Consts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PRIOXIS_CRM_POC_CoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
