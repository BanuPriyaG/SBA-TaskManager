using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskManager.BusinessLayer;
using TaskManager.DataLayer;

namespace TaskManager.ServiceLayer.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController,IDisposable
    {
        public IHttpActionResult GetAllUsers()
        {
            try
            {
                var response = Users.GetAllUsers();
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult GetUser(int userId)
        {
            try
            {
                var response = Users.GetUserById(userId);
                if (response != null) return Ok(response);
                else return NotFound();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IHttpActionResult Post(User user)
        {
            try
            {
                Users.AddUser(user);
                return Ok("Added");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult Put(User user)
        {
            try
            {
                Users.UpdateUser(user);
                return Ok("Updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IHttpActionResult Delete(int userId)
        {
            try
            {
                Users.DeleteUser(userId);
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