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
        public DbSet<Project> Projects { get; set; }

        public Repository() : base(GetConnection(), false)
        {
            if (Database.CreateIfNotExists())
            {

                Repository repository = this;

                Credencial credencial = new Credencial("douglasbadaro@mail.com", "123456", true, true);
                Developer developer = new Developer("Douglas Badaró", new DateTime(2006 - 01 - 14), Convert.ToChar("J"));
                credencial.Developer = developer;
                developer.Credencial = credencial;

                repository.Developers.Add(developer);
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
