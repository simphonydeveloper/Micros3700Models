using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_emp_dtl
    {
        public int hist_seq { get; set; }
        public int emp_seq { get; set; }
        public int? inactive_reason_seq { get; set; }
        public DateTime? hire_date { get; set; }
        public string ob_rehire { get; set; }
        public DateTime? inactive_from_date { get; set; }
        public DateTime? inactive_to_date { get; set; }
        public int? termination_reason_1_seq { get; set; }
        public int? termination_reason_2_seq { get; set; }
        public int? termination_reason_3_seq { get; set; }
        public int? termination_reason_4_seq { get; set; }
        public string transfer_to_store { get; set; }
        public DateTime? termination_date { get; set; }
        public string termination_status { get; set; }
        public string current_employment_status { get; set; }
        public DateTime? change_date { get; set; }
        public int? change_by { get; set; }
    }
}
