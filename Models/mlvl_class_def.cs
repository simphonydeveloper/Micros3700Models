using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mlvl_class_def
    {
        public int mlvl_class_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public string ob_ml01_main_mlvl_1_active { get; set; }
        public string ob_ml02_main_mlvl_2_active { get; set; }
        public string ob_ml03_main_mlvl_3_active { get; set; }
        public string ob_ml04_main_mlvl_4_active { get; set; }
        public string ob_ml_main_mlvl_5_active { get; set; }
        public string ob_ml_main_mlvl_6_active { get; set; }
        public string ob_ml_main_mlvl_7_active { get; set; }
        public string ob_ml_main_mlvl_8_active { get; set; }
        public string ob_ml_main_mlvl_9_active { get; set; }
        public string ob_ml_main_mlvl_10_active { get; set; }
        public string ob_ml05_sub_mlvl_1_active { get; set; }
        public string ob_ml06_sub_mlvl_2_active { get; set; }
        public string ob_ml07_sub_mlvl_3_active { get; set; }
        public string ob_ml08_sub_mlvl_4_active { get; set; }
        public string ob_ml_sub_mlvl_5_active { get; set; }
        public string ob_ml_sub_mlvl_6_active { get; set; }
        public string ob_ml_sub_mlvl_7_active { get; set; }
        public string ob_ml_sub_mlvl_8_active { get; set; }
        public string ob_ml_sub_mlvl_9_active { get; set; }
        public string ob_ml_sub_mlvl_10_active { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public string ob_rsvd08 { get; set; }
        public short? pop_main_mlvl { get; set; }
        public short? pop_sub_mlvl { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
