using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.DataLayer;

namespace TaskManager.BusinessLayer
{
    public static class Projects
    {
        public static List<GetProjectsList_Result> GetProjectBasedTaskDetails()
        {
            ProjectDataLayer dataLayer = new ProjectDataLayer();
            return dataLayer.GetProjectBasedTaskDetails();
        }

        public static List<Project> GetProjectByName(string projectName)
        {
            ProjectDataLayer dataLayer = new ProjectDataLayer();
            return dataLayer.GetProjectByName(projectName);
        }

        public static Project GetProjectById(int projectId)
        {
            ProjectDataLayer dataLayer = new ProjectDataLayer();
            return dataLayer.GetProjectById(projectId);
        }

        public static void AddProject(Project project)
        {
            ProjectDataLayer dataLayer = new ProjectDataLayer();
            dataLayer.AddProject(project);
        }

        public static void UpdateProject(Project project)
        {
            ProjectDataLayer dataLayer = new ProjectDataLayer();
            dataLayer.UpdateProject(project);
        }

        public static void DeleteProject(int projectId)
        {
            ProjectDataLayer dataLayer = new ProjectDataLayer();
            dataLayer.DeleteProject(projectId);
        }
    }
}
