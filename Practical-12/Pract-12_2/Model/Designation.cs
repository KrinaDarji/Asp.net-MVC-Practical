using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Designation
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string DesignationName { get; set; }
    }
}
