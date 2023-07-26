using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class dly_pm_waste_ttl
    {
        public int store_id { get; set; }
        public DateTime business_date { get; set; }
        public int rvc_seq { get; set; }
        public int emp_seq { get; set; }
        public int mi_seq { get; set; }
        public int? rvc_num { get; set; }
        public string rvc_name { get; set; }
        public int? emp_num { get; set; }
        public string emp_last_name { get; set; }
        public string emp_first_name { get; set; }
        public int? mi_num { get; set; }
        public string mi_name { get; set; }
        public int price_lvl { get; set; }
        public short? quantity { get; set; }
        public decimal? amount { get; set; }
        public decimal? cost { get; set; }
        public int em_ttl_repl_seq { get; set; }
        public string mlvl_name { get; set; }
        public int waste_reason_seq { get; set; }
        public string waste_reason { get; set; }
    }
}
