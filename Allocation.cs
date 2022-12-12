using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Allocation_Management
{
    [Table("tbl_allocation")]
    internal class Allocation
    {
        public DateTime Start { get; set; }
        public DateTime Termination { get; set; }
        public Byte HoursWeekly { get; set; }
        public Decimal Remuneration { get; set; }
        public Developer Developer { get; set; }
        public Project Project { get; set; }
        public List<Tasks> Tasks { get; set; }

        public Allocation(DateTime start, DateTime termination, byte hoursWeekly, decimal remuneration, Developer developer, Project project)
        {
            Start = start;
            Termination = termination;
            HoursWeekly = hoursWeekly;
            Remuneration = remuneration;
            Developer = developer;
            Project = project;
        }
    }
}
