using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class hist_emp_salary_dtl
    {
        public int emp_seq { get; set; }
        public int hist_seq { get; set; }
        public decimal? hourly_salary { get; set; }
        public decimal? daily_salary { get; set; }
        public decimal? weekly_salary { get; set; }
        public decimal? four_week_salary { get; set; }
        public decimal? monthly_salary { get; set; }
        public decimal? annual_salary { get; set; }
        public string salary_rate_type { get; set; }
        public DateTime? effective_gmt_datetime { get; set; }
        public DateTime? change_date { get; set; }
        public int? change_by { get; set; }
    }
}
