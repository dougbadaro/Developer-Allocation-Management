using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    internal class ProjectRepository
    {
        public static void Save(Project project)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (project.Id == 0)
                    {
                        dbContext.Projects.Add(project);
                    }
                    else
                    {
                        dbContext.Entry(project).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Project> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Project> FindByPartialName(string partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Projects.Where(p => p.Name.Contains(partialName)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
