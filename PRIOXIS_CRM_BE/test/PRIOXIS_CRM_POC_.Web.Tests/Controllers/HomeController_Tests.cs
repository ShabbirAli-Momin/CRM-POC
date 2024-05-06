using System.Threading.Tasks;
using PRIOXIS_CRM_POC_.Models.TokenAuth;
using PRIOXIS_CRM_POC_.Web.Controllers;
using Shouldly;
using Xunit;

namespace PRIOXIS_CRM_POC_.Web.Tests.Controllers
{
    public class HomeController_Tests: PRIOXIS_CRM_POC_WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}