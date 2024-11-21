using System.Threading.Tasks;
using MyAbpProject.Models.TokenAuth;
using MyAbpProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyAbpProject.Web.Tests.Controllers
{
    public class HomeController_Tests: MyAbpProjectWebTestBase
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