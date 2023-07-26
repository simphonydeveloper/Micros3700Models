using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dashboard_employee_labor_ttl
    {
        public int emp_seq { get; set; }
        public string employee { get; set; }
        public string hours { get; set; }
        public decimal? accum_hrs { get; set; }
        public int? emp_in_ovt_alert { get; set; }
        public string dly_hours { get; set; }
        public decimal? accum_dly_hrs { get; set; }
    }
}
