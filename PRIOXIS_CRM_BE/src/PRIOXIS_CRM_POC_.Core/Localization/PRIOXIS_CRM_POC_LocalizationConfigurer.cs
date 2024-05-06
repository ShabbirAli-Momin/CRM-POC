using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace PRIOXIS_CRM_POC_.Localization
{
    public static class PRIOXIS_CRM_POC_LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(PRIOXIS_CRM_POC_Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(PRIOXIS_CRM_POC_LocalizationConfigurer).GetAssembly(),
                        "PRIOXIS_CRM_POC_.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
