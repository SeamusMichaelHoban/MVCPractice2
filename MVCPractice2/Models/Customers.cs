using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPractice2.Models
{
    public class Customers
    {
        [Key]
        public int Name { get; set; }
        public int Address { get; set; }
        public int Telephone { get; set; }
    }
}