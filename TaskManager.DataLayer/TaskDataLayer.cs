using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Entities;

namespace TaskManager.DataLayer
{
    public class TaskDataLayer
    {
        public List<TaskModel> GetTasksList()
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Tasks.ToList();
            }
        }

        public TaskModel GetTaskById(int taskId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Tasks.Find(taskId);
            }
        }

        public void AddTask(TaskModel task)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.Tasks.Add(task);
                dbContext.SaveChanges();
            }
        }

        public void UpdateTask(TaskModel task)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.Entry(task).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void DeleteTask(int taskId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                var task = dbContext.Tasks.Find(taskId);
                if (task != null)dbContext.Tasks.Remove(task);
                dbContext.SaveChanges();
            }
        }
    }
}
