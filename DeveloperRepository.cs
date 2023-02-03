using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Developer_Allocation_Management
{
    internal class DeveloperRepository
    {
        public static void Save(Developer developer)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (developer.Id == 0)
                    {
                        dbContext.Developers.Add(developer);
                    }
                    else
                    {
                        dbContext.Entry(developer).State = EntityState.Modified;
                        dbContext.Entry(developer.Credential).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred.");
                throw;
            }
        }

        public static List<Developer> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("Credential").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Developer> FindByPartialName(String partialName)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include(d => d.Credential).Where(d => d.Name.Contains(partialName)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Developer> FindByProject(Project project)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include(a => a.Developer)
                                                .Include(a => a.Project)
                                                .Where(a => a.Project.Id == project.Id)
                                                .Select(a => a.Developer)
                                                .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Developer FindByIdEProject(Int64 id, Project project)
        {
            try
            {
                List<Developer> developers = FindByProject(project);

                return developers.FirstOrDefault(d => d.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
