using PRIOXIS_CRM_POC_.Debugging;

namespace PRIOXIS_CRM_POC_
{
    public class PRIOXIS_CRM_POC_Consts
    {
        public const string LocalizationSourceName = "PRIOXIS_CRM_POC_";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "7f2baa335a784e0fbe952fdcb88024e2";
    }
}
