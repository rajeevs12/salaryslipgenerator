using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BussinessEntites
{

    public class Employee
    {
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public int Annual_salary { get; set; }
        [Required]
        public int Super_rate { get; set; }
        [Required]
        public string Payment_start_date { get; set; }
    }
}
