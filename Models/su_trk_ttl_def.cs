using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class su_trk_ttl_def
    {
        public int su_trk_grp_seq { get; set; }
        public int su_trk_ttl_seq { get; set; }
        public string name { get; set; }
        public short? ttl_type { get; set; }
        public int? ttl_num { get; set; }
        public string ob_sutgrp01_dont_prn_ttl { get; set; }
        public string ob_sutgrp02_subtract { get; set; }
        public string ob_sutgrp03_dont_reset { get; set; }
        public string ob_sutgrp04_chk_decl_media { get; set; }
        public string ob_sutgrp05_exception_amt { get; set; }
        public string ob_sutgrp06_exception_cnt { get; set; }
        public string ob_sutgrp07_prn_in_red { get; set; }
        public decimal? commission { get; set; }
        public decimal? threshold_amt { get; set; }
        public int? threshold_cnt { get; set; }
        public int? last_updated_by { get; set; }
    }
}
