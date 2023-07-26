using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class em_cm_employee_receptacle_assignment_dtl
    {
        public int store_id { get; set; }
        public int receptacle_seq { get; set; }
        public int employee_seq { get; set; }
        public string employee_assigned { get; set; }
    }
}
