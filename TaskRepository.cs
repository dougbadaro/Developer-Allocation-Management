using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Developer_Allocation_Management
{
    internal class TaskRepository
    {
        public static void Save(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(task.Allocation).State = EntityState.Unchanged;

                    if (task.Id == 0)
                    {
                        dbContext.Tasks.Add(task);
                    }
                    else
                    {
                        dbContext.Entry(task).State = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Task> FindByAllocation(Int64 allocation)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    //dbContext.Allocations.Attach(allocation);

                    return dbContext.Tasks.Where(t => t.Allocation.Id == allocation).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
