using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayCareManagement.Models
{
    public class Rules
    {
        public string AgeGroup { get; set; }
        public int GroupSize { get; set; }
        public string Ratio { get; set; }
        public string MaxGroups { get; set; }
    }
}
