using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageEmployees.Models.Entities
{
    public class Employees
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { set; get; }
        public string Phone { set; get; }
        public string Image { set; get; }
    }
}
