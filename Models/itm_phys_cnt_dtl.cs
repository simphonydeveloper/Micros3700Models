using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class itm_phys_cnt_dtl
    {
        public int inven_loc_seq { get; set; }
        public int phys_cnt_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public int ilcg_seq { get; set; }
        public double? maj_unit_cnt { get; set; }
        public int? maj_unit_seq { get; set; }
        public double? sub_unit_cnt { get; set; }
        public int? sub_unit_seq { get; set; }
        public double? sub_unit2_cnt { get; set; }
        public int? sub_unit2_seq { get; set; }
        public double? sub_unit3_cnt { get; set; }
        public int? sub_unit3_seq { get; set; }
        public double? sub_unit4_cnt { get; set; }
        public int? sub_unit4_seq { get; set; }
        public double? sub_unit5_cnt { get; set; }
        public int? sub_unit5_seq { get; set; }
    }
}
