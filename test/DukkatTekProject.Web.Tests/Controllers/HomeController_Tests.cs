using System.Threading.Tasks;
using DukkatTekProject.Models.TokenAuth;
using DukkatTekProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace DukkatTekProject.Web.Tests.Controllers
{
    public class HomeController_Tests: DukkatTekProjectWebTestBase
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