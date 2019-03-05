using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal WeeklyWage { get; set; }

        public override string ToString()
        {
            return $"{Name} {JoinDate.ToShortDateString()} {WeeklyWage:C}";
        }
    }
}
