using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models {
    public class Employee {
        public int EmpolyeeId { get; set; }
        public string Employeename { get; set; }
        public string Department { get; set; }
        public string DateOfJoining { get; set; }
        public string PhotoFileName { get; set; }
    }
}