using System.Threading.Tasks;
using Maps.Models.TokenAuth;
using Maps.Web.Controllers;
using Shouldly;
using Xunit;

namespace Maps.Web.Tests.Controllers
{
    public class HomeController_Tests: MapsWebTestBase
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