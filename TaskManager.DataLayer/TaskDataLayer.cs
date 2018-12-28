using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Entities;

namespace TaskManager.DataLayer
{
    public class TaskDataLayer
    {
        public List<Task> GetTasksList()
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Tasks.ToList();
            }
        }
        public List<Task> GetTasksByName(string taskName)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Tasks.Where(x => x.Task1.Contains(taskName)).ToList();
            }
        }
        public List<Task> GetTasksByProjectID(int projId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Tasks.Where(x => x.Project_ID == projId).ToList();
            }
        }

        public Task GetTaskById(int taskId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Tasks.Find(taskId);
            }
        }

        public void AddTask(Task task, int? userId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                ObjectParameter outObj = new ObjectParameter("Identity", 0);
                dbContext.InsertTaskAndUpdateUser(task.Task1, task.Start_Date, task.End_Date,
                    task.Priority, task.ParentTask, task.Project_ID, task.Status, userId, outObj);
                dbContext.SaveChanges();
            }
        }

        public void UpdateTask(Task task)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                dbContext.Entry(task).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void DeleteTask(int taskId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                var task = dbContext.Tasks.Find(taskId);
                if (task != null)dbContext.Tasks.Remove(task);
                dbContext.SaveChanges();
            }
        }
    }
}
