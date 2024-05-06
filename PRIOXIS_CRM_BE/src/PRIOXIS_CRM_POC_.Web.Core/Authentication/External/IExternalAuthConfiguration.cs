using System.Collections.Generic;

namespace PRIOXIS_CRM_POC_.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
