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
    public class Projects
    {

        [Test]
        public void Test_GetProjectBasedTaskDetails()
        {
            var controller = new ProjectsController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetProjectBasedTaskDetails();
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<List<TaskManager.DataLayer.GetProjectsList_Result>>>(result);
        }

        [Test]
        public void Test_GetProjectByName()
        {
            var controller = new ProjectsController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetProjectByName("");
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<List<TaskManager.DataLayer.Project>>>(result);
        }

        [Test]
        public void Test_GetProject()
        {
            var controller = new ProjectsController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetProject(1);
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<TaskManager.DataLayer.Project>>(result);
        }

        [Test]
        public void Test_Post()
        {
            var controller = new ProjectsController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var project = new TaskManager.DataLayer.Project()
            {
                Project1 = "Project4",                
                Start_Date = DateTime.Now,
                End_Date = new DateTime(2018, 12, 16),
                Priority = 3                
            };
            var result = controller.Post(project);
            Assert.NotNull(result);
            Assert.AreSame("Added", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }

        [Test]
        public void Test_Put()
        {
            var controller = new ProjectsController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var project = new TaskManager.DataLayer.Project()
            {
                Project_ID = 2,
                Project1 = "Project1",
                Start_Date = DateTime.Now,
                End_Date = new DateTime(2019, 12, 16),
                Priority = 3
            };
            var result = controller.Put(project);
            Assert.NotNull(result);
            Assert.AreSame("Updated", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }

        [Test]
        public void Test_Delete()
        {
            var controller = new ProjectsController();
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
