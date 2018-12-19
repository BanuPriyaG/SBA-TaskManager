using System;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskManager.BusinessLayer;
using TaskManager.DataLayer;

namespace TaskManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProjectsController : ApiController,IDisposable
    {
        public IHttpActionResult GetAllProjects()
        {
            try
            {
                var response = Projects.GetAllProjects();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult GetProject(int projectId)
        {
            try
            {
                var response = Projects.GetProjectById(projectId);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IHttpActionResult Post(Project project)
        {
            try
            {
                Projects.AddProject(project);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult Put(Project project)
        {
            try
            {
                Projects.UpdateProject(project);
                return Ok("Updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult Delete(int projectId)
        {
            try
            {
                Projects.DeleteProject(projectId);
                return Ok("Deleted");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public new void Dispose()
        {
            GC.Collect();
        }
    }
}
