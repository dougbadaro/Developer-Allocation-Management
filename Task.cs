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
    public class Task
    {
        public Int64 Id { get; set; }

        [StringLength(200)]
        public String Description { get; set; }
        public Allocation Allocation { get; set; }
        public Task() { }
        public Task(string description, Allocation allocation)
        {
            Description = description;
            Allocation = allocation;
        }

        public override string ToString()
        {
            return $"{Description}";
        }
    }
}
