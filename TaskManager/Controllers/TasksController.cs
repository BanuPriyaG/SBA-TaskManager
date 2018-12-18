using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskManager.BusinessLayer;
using TaskManager.DataLayer;

namespace TaskManager.ServiceLayer.Controllers
{
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class TasksController : ApiController
    {
        public IHttpActionResult GetAllTasks()
        {
            try
            {
                var response = Tasks.GetAllTasks();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult GetTask(int taskId)
        {
            try
            {
                var response = Tasks.GetTaskById(taskId);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IHttpActionResult Post(TaskModel task)
        {
            try
            {
                Tasks.AddTask(task);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult Put(TaskModel task)
        {
            try
            {
                Tasks.UpdateTask(task);
                return Ok("Updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult Delete(int taskId)
        {
            try
            {
                Tasks.DeleteTask(taskId);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
