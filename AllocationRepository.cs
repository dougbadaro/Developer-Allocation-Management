using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Developer_Allocation_Management
{
    public class AllocationRepository
    {
        public static void Save(Allocation allocation)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {

                    dbContext.Entry(allocation.Developer).State = EntityState.Unchanged;
                    dbContext.Entry(allocation.Project).State = EntityState.Unchanged;

                    if (allocation.Id == 0)
                    {
                        dbContext.Allocations.Add(allocation);
                    }
                    else
                    {
                        dbContext.Entry(allocation).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                    Console.WriteLine(dbContext.ChangeTracker);

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static Allocation FindById(Int64 allocation)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    //Na linha abaixo, utilizo o Include de Developer e Project para poder utilizá-los em seu ToString()
                    return dbContext.Allocations.Include(a => a.Developer).Include(a => a.Project).FirstOrDefault(a => a.Id == allocation);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
        public static List<Allocation> FindByDevProj(string devprojid)
        {
            
            try 
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                        .Include(a => a.Developer)
                        .Include(a => a.Project)
                        .Where(a => a.Developer.Name.Contains(devprojid) || a.Project.Name.Contains(devprojid)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
