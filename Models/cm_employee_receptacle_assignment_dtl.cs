using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_employee_receptacle_assignment_dtl
    {
        public int receptacle_seq { get; set; }
        public int employee_seq { get; set; }
        public string employee_assigned { get; set; }
    }
}
