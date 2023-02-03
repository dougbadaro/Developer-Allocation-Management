using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    [Table("tbl_allocation")]
    public class Allocation
    {
        public Int64 Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Termination { get; set; }
        public Byte HoursWeekly { get; set; }
        public Decimal Remuneration { get; set; }
        [Required]
        public Developer Developer { get; set; }
        [Required]
        public Project Project { get; set; }
        public List<Task> Tasks { get; set; }

        public Allocation()
        {
            Tasks = new List<Task>();
        }

        public Allocation (DateTime start, DateTime termination, byte hoursWeekly, decimal remuneration, Developer developer, Project project) : this()
        {
            Start = start;
            Termination = termination;
            HoursWeekly = hoursWeekly;
            Remuneration = remuneration;
            Developer = developer;
            Project = project;
        }

        public override string ToString()
        {
            return $"{Developer}, Start: {Start.ToString("dd-MM-yyyy")}";
        }
    }
}
