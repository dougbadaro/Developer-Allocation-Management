using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                throw;
            }
        }

        public static Developer AuthenticateDeveloper(String email)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Developers.Include("Credencial").Where(d => d.Credencial.Email == email).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
