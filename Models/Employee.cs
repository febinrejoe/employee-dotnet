using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace employee.Models
{
    [Table("employee")]
    public class Employee
    {
        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }
    }
}
