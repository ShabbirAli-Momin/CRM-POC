using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PRIOXIS_CRM_POC_.EntityFrameworkCore
{
    public static class PRIOXIS_CRM_POC_DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PRIOXIS_CRM_POC_DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PRIOXIS_CRM_POC_DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
