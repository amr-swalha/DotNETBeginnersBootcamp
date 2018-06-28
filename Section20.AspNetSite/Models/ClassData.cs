using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section20.AspNetSite.Models
{
    public class ClassData
    {
        public string ClassName { get; set; }
        public DateTime StartDate { get; set; }
        public List<string> StudentEnrolled { get; set; }
    }
}
