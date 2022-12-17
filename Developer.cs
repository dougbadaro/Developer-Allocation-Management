using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    [Table("tbl_developer")]
    public class Developer
    {
        public Int64 Id { get; set; }

        [StringLength(45)]
        public String Name { get; set; }
        public DateTime BirthDay { get; set; }

        public Char LetterLevel { get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public String Level
        {
            get
            {
                return LetterLevel.ToString();
            }

            set
            {
                LetterLevel = value[0];
            }
        }

        public Credential Credential { get; set; }

        public Developer()
        {
        }

        public Developer(string name, DateTime birthDay, char letterLevel)
        {
            Name = name;
            BirthDay = birthDay;
            LetterLevel = letterLevel;
        }
    }
}
