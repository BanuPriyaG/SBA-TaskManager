using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Results;
using TaskManager.DataLayer;
using TaskManager.ServiceLayer.Controllers;

namespace TaskManger.Test
{
    [TestFixture]
    public class Tasks
    {
        [Test]
        public void Test_GetAllTasks()
        {
            var controller = new TasksController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetAllTasks();
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<List<TaskManager.DataLayer.Task>>>(result);
        }

        [Test]
        public void Test_GetTaskById()
        {
            var controller = new TasksController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.GetTask(1);
            Assert.NotNull(result);
            Assert.IsInstanceOf<OkNegotiatedContentResult<TaskManager.DataLayer.Task>>(result);
        }

        [Test]
        public void Test_Post()
        {
            var controller = new TasksController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var task = new TaskManager.DataLayer.Task()
            {
                Task_Id = 4,
                Task1 = "task4",
                ParentTask = "task1",
                Start_Date = DateTime.Now,
                End_Date = new DateTime(2018, 12, 16),
                Priority = 3
            };
            var result = controller.Post(task, 2);
            Assert.NotNull(result);
            Assert.AreSame("Added", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }

        [Test]
        public void Test_Put()
        {
            var controller = new TasksController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var task = new TaskManager.DataLayer.Task()
            {
                Task_Id = 1,
                Task1 = "task1",
                ParentTask = "task3",
                Start_Date = DateTime.Now,
                End_Date = new DateTime(2018, 12, 12),
                Priority = 1
            };
            var result = controller.Put(task);
            Assert.NotNull(result);
            Assert.AreSame("Updated", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }

        [Test]
        public void Test_Delete()
        {
            var controller = new TasksController();
            controller.Request = new HttpRequestMessage()
            {
                RequestUri = new Uri("http://localhost")
            };
            var result = controller.Delete(4);
            Assert.NotNull(result);
            Assert.AreSame("Deleted", (result as OkNegotiatedContentResult<string>).Content);
            Assert.IsInstanceOf<OkNegotiatedContentResult<string>>(result);
        }
    }
}
