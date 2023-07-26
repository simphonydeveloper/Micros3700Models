using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class acctng_prd_def
    {
        public int acctng_prd_seq { get; set; }
        public int acctng_year_seq { get; set; }
        public int? aseq_seq { get; set; }
        public int? inven_cnt_task_seq { get; set; }
        public string name { get; set; }
        public DateTime begin_date { get; set; }
        public DateTime end_date { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
