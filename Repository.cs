using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    internal class Repository : DbContext
    {
        private static MySqlConnection _dbConnection;

        public DbSet<Developer> Developers { get; set; }
        public DbSet<Credential> Credentials { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<Tasks> Tasks { get; set; }

        public Repository() : base(GetConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {

                Repository repository = this;

                Credential credencial = new Credential("douglasbadaro@mail.com", "123456", true, true);
                Developer developer = new Developer("Douglas Badaró", DateTime.Parse("2006 - 01 - 14"), 'J');
                credencial.Developer = developer;
                developer.Credential = credencial;

                repository.Developers.Add(developer);

                Project project = new Project("Automação", DateTime.Parse("2021-06-21"), DateTime.Parse("2022-12-23"), DateTime.Parse("2022-12-23"));
                repository.Projects.Add(project);

                Allocation allocation = new Allocation(DateTime.Parse("2021-06-21"), DateTime.Parse("2022-12-23"), 8, 160.0m, developer, project);
                repository.Allocations.Add(allocation);

                repository.SaveChanges();
            }
        }

        public static MySqlConnection GetConnection()
        {
            if (_dbConnection == null)
            {
                String connectionString = ConfigurationManager.ConnectionStrings["DeveloperManagementString"].ConnectionString;

                _dbConnection = new MySqlConnection(connectionString);
            }

            return _dbConnection;
        }
    }
}
