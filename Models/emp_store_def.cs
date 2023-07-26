using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class emp_store_def
    {
        public int store_id { get; set; }
        public int emp_seq { get; set; }
        public int? emp_bo_class_seq { get; set; }
        public int? emp_class_seq { get; set; }
        public decimal? id { get; set; }
        public decimal? pc_appl_id { get; set; }
        public DateTime? effective_to { get; set; }
        public DateTime? effective_from { get; set; }
        public string ob_foh_pwd_managed { get; set; }
        public string ob_boh_pwd_managed { get; set; }
        public int? store_emp_seq { get; set; }
        public string ob_primary_store { get; set; }
    }
}
