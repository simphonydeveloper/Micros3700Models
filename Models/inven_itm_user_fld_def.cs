using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_user_fld_def
    {
        public int inven_itm_seq { get; set; }
        public string alpha_1 { get; set; }
        public string alpha_2 { get; set; }
        public string alpha_3 { get; set; }
        public string alpha_4 { get; set; }
        public string alpha_5 { get; set; }
        public double? numeric_1 { get; set; }
        public double? numeric_2 { get; set; }
        public double? numeric_3 { get; set; }
        public double? numeric_4 { get; set; }
        public int? integer_1 { get; set; }
        public int? integer_2 { get; set; }
        public int? integer_3 { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
