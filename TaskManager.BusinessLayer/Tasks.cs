﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataLayer;

namespace TaskManager.BusinessLayer
{
    public static class Tasks
    {
        public static List<DataLayer.Task> GetAllTasks()
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            return dataLayer.GetTasksList();
        }

        public static List<DataLayer.Task> GetTasksByProjectID(int projId)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            return dataLayer.GetTasksByProjectID(projId);
        }
        public static DataLayer.Task GetTaskById(int taskId)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            return dataLayer.GetTaskById(taskId);
        }

        public static List<DataLayer.Task> GetTasksByName(string taskName)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            return dataLayer.GetTasksByName(taskName);
        }

        public static void AddTask(DataLayer.Task task, int? userId)
        {
            TaskDataLayer dataLayer = new TaskDataLayer();
            dataLayer.AddTask(task, userId);
        }

        public static void UpdateTask(DataLayer.Task task)
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
