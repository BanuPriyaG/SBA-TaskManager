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
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Projects.ToList();
            }
        }

        public Project GetProjectById(int projectId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                return dbContext.Projects.Find(projectId);
            }
        }

        public void AddProject(Project project)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.Projects.Add(project);
                dbContext.SaveChanges();
            }
        }

        public void UpdateProject(Project project)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                dbContext.Entry(project).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void DeleteProject(int projectId)
        {
            using (CapsuleEntities2 dbContext = new CapsuleEntities2())
            {
                var project = dbContext.Projects.Find(projectId);
                if (project != null) dbContext.Projects.Remove(project);
                dbContext.SaveChanges();
            }
        }
    }
}
