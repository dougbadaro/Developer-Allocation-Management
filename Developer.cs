using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    [Table("tbl_developer")]
    internal class Developer
    {
        public Int64 Id { get; set; }
        public String Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Char Level { get; set; }
        public Credential Credencial { get; set; }

        public Developer()
        {
        }

        public Developer(string name, DateTime birthDay, char level)
        {
            Name = name;
            BirthDay = birthDay;
            Level = level;
        }
    }
}
