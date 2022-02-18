using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeModel
{
    public class EmployeeTable
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Joining Data")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime? DOB { get; set; }
        public int Age { get; set; }
    }
}
