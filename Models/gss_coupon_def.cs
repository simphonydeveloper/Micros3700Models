using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_coupon_def
    {
        public int coupon_seq { get; set; }
        public string name { get; set; }
        public int expire_type { get; set; }
        public int? expire_number { get; set; }
        public DateTime? expire_date { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }
        public string text3 { get; set; }
        public string text4 { get; set; }
        public string text5 { get; set; }
        public string text6 { get; set; }
        public int? text1_attr { get; set; }
        public int? text2_attr { get; set; }
        public int? text3_attr { get; set; }
        public int? text4_attr { get; set; }
        public int? text5_attr { get; set; }
        public int? text6_attr { get; set; }
        public DateTime? issue_from { get; set; }
        public DateTime? issue_to { get; set; }
    }
}
