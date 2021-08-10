using Easypeasy.User.Service.Controllers;
using Easypeasy.User.Service.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Easypeasy.User.Service.Test
{
    public class UserControllerTest
    {
        [Theory]
        [InlineData("mail2udita@gmail.com")]
        public async Task test_GetUserByEmail(string emailid)
        {
            var mockUservice = new Mock<IUserService>();
            mockUservice.Setup(x => x.GetUserByEmail(emailid)).Returns(new Domain.User { userid = emailid });

            var sut = new UserController(mockUservice.Object);

            var actionresult = sut.GetUserById(emailid).Result;
            var result = (actionresult as OkObjectResult).Value as Domain.User;

            var expected = new Domain.User { userid = "mail2udita@gmail.com" };

            Assert.Equal(expected.userid, result.userid);
        }
    }
}
