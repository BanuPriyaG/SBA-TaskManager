using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using TaskManager.ServiceLayer.Controllers;

namespace TaskManager.Test
{
    [TestFixture]
    public class Users
    {

        [Test]
        public void Test_GetAllUsers()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetAllUsers();
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<List<TaskManager.DataLayer.User>>>(result);
        }

        [Test]
        public void Test_GetByUserName()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetByUserName("");
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<List<TaskManager.DataLayer.User>>>(result);
        }

        [Test]
        public void Test_GetUser()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetUser(1);
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<TaskManager.DataLayer.User>>(result);
        }

        [Test]
        public void Test_Post()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var user = new TaskManager.DataLayer.User()
            {
                FirstName = "first",
                LastName ="last",
                Employee_ID = 12345,
                Project_ID = 2,
                User_ID = 2
            };
            var result = controller.Post(user);
            Assert.NotNull(result);
            Assert.AreSame("Added", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }

        [Test]
        public void Test_Put()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var user = new TaskManager.DataLayer.User()
            {
                FirstName = "first",
                LastName = "last",
                Employee_ID = 12345,
                Project_ID = 2,
                User_ID = 2
            };
            var result = controller.Put(user);
            Assert.NotNull(result);
            Assert.AreSame("Updated", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }

        [Test]
        public void Test_Delete()
        {
            var controller = new UsersController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.Delete(2);
            Assert.NotNull(result);
            Assert.AreSame("Deleted", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }
    }
}
