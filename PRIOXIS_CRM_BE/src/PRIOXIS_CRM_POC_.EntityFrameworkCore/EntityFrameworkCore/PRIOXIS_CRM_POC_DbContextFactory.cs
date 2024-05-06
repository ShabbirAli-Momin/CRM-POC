using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PRIOXIS_CRM_POC_.Configuration;
using PRIOXIS_CRM_POC_.Web;

namespace PRIOXIS_CRM_POC_.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PRIOXIS_CRM_POC_DbContextFactory : IDesignTimeDbContextFactory<PRIOXIS_CRM_POC_DbContext>
    {
        public PRIOXIS_CRM_POC_DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PRIOXIS_CRM_POC_DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PRIOXIS_CRM_POC_DbContextConfigurer.Configure(builder, configuration.GetConnectionString(PRIOXIS_CRM_POC_Consts.ConnectionStringName));

            return new PRIOXIS_CRM_POC_DbContext(builder.Options);
        }
    }
}
