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

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Allocation> FindAll()
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations
                        .Include(a => a.Developer)
                        .Include(a => a.Project)
                        .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void AddTask(Allocation allocation, Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    Allocation allocationDB = dbContext.Allocations.FirstOrDefault(a => a.Id == allocation.Id);
                    allocationDB.Tasks.Add(task);

                    dbContext.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void RemoveTask(Task task)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    dbContext.Entry(task).State = EntityState.Deleted;
                    dbContext.SaveChanges();
                }
            }
            catch (Exception)
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
        public static List<Task> GetTasks(Int64 id)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    Allocation allocation = dbContext.Allocations.Include(a => a.Tasks).FirstOrDefault(a => a.Id == id);

                    return allocation.Tasks.ToList();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Task> GetTaskByIdDeveloper(Int64 id)
        {
            try
            {
                using(Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include(a => a.Developer)
                                                .Where(a => a.Developer.Id == id)
                                                .Select(a => a.Tasks)
                                                .FirstOrDefault()
                                                .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Allocation> FindByProject(Project project)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include(a => a.Developer)
                                                .Include(a => a.Project)
                                                .Where(a => a.Project.Id == project.Id)
                                                .ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<Allocation> FindForDate(Project project, Developer developer)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    return dbContext.Allocations.Include(a => a.Project).Where(a => a.Project.Id == project.Id && a.Developer.Id == developer.Id).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
