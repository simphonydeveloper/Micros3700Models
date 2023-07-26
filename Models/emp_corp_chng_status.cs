using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_corp_chng_status
    {
        public int emp_corp_chng_seq { get; set; }
        public int? emp_seq { get; set; }
        public int? manager_emp_seq { get; set; }
        public string code { get; set; }
        public DateTime? chng_date { get; set; }
        public DateTime? tx_date { get; set; }
        public short? status { get; set; }
        public short? retx_cnt { get; set; }
        public int? temp_emp_obj_num { get; set; }
        public string ob_file_sent { get; set; }
        public int? job_seq { get; set; }
    }
}
