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
                    return dbContext.Developers.Where(d => d.Name.Contains(partialName)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
