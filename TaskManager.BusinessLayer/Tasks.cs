using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataLayer;

namespace TaskManager.BusinessLayer
{
    public static class Tasks
    {
        public static List<TaskModel> GetAllTasks()
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            return dataLayer.GetTasksList();
        }

        public static TaskModel GetTaskById(int taskId)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            return dataLayer.GetTaskById(taskId);
        }

        public static void AddTask(TaskModel task)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            dataLayer.AddTask(task);
        }

        public static void UpdateTask(TaskModel task)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            dataLayer.UpdateTask( task);
        }

        public static void DeleteTask(int taskId)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            dataLayer.DeleteTask(taskId);
        }
    }
}
