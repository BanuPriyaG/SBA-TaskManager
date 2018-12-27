using System;
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

        public IHttpActionResult GetTasksByName(string taskName)
        {
            try
            {
                var response = Tasks.GetTasksByName(taskName);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IHttpActionResult GetTasksByProjectID(int projId)
        {
            try
            {
                var response = Tasks.GetTasksByProjectID(projId);
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
        public IHttpActionResult Post(DataLayer.Task task)
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

        public IHttpActionResult Put(DataLayer.Task task)
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
