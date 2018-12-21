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
                return dbContext.TaskModels.ToList();
            }
        }

        public List<TaskModel> GetTasksByProjectID(int projId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.TaskModels.Where(x => x.Project_ID == projId).ToList();
            }
        }

        public TaskModel GetTaskById(int taskId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.TaskModels.Find(taskId);
            }
        }

        public void AddTask(TaskModel task)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.TaskModels.Add(task);
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
                var task = dbContext.TaskModels.Find(taskId);
                if (task != null)dbContext.TaskModels.Remove(task);
                dbContext.SaveChanges();
            }
        }
    }
}
