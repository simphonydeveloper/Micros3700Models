using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_lineref_dtl
    {
        public int store_id { get; set; }
        public int fin_config_seq { get; set; }
        public int fin_prd_seq { get; set; }
        public int fin_log_lineref_seq { get; set; }
        public int fin_lineref_seq { get; set; }
        public double? value { get; set; }
    }
}
