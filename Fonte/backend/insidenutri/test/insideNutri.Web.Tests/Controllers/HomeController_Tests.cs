using System.Threading.Tasks;
using insideNutri.Models.TokenAuth;
using insideNutri.Web.Controllers;
using Shouldly;
using Xunit;

namespace insideNutri.Web.Tests.Controllers
{
    public class HomeController_Tests: insideNutriWebTestBase
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