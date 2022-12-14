using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    [Table("tbl_tasks")]
    internal class Tasks
    {
        public Int64 Id { get; set; }

        [StringLength(200)]
        public String Description { get; set; }
        public Tasks(string description)
        {
            Description = description;
        }
    }
}
