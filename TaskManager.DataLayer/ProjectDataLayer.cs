using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.DataLayer
{
    public class ProjectDataLayer
    {
        public List<Project> GetProjectsList()
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Projects.ToList();
            }
        }

        public List<Project> GetProjectByName(string projectName)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                var result = dbContext.Projects.Where(a => a.Project1.Contains(projectName));
                return result.ToList();
            }
        }

        public Project GetProjectById(int projectId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                return dbContext.Projects.Find(projectId);
            }
        }

        public void AddProject(Project project)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                dbContext.Projects.Add(project);
                dbContext.SaveChanges();
            }
        }

        public void UpdateProject(Project project)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                dbContext.Entry(project).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void DeleteProject(int projectId)
        {
            using (CapsuleEntities dbContext = new CapsuleEntities())
            {
                var project = dbContext.Projects.Find(projectId);
                if (project != null) dbContext.Projects.Remove(project);
                dbContext.SaveChanges();
            }
        }
    }
}
