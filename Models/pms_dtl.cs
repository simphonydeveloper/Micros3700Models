using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class pms_dtl
    {
        public int trans_seq { get; set; }
        public int dtl_seq { get; set; }
        public decimal? pms_sls_itmzr_01 { get; set; }
        public decimal? pms_sls_itmzr_02 { get; set; }
        public decimal? pms_sls_itmzr_03 { get; set; }
        public decimal? pms_sls_itmzr_04 { get; set; }
        public decimal? pms_sls_itmzr_05 { get; set; }
        public decimal? pms_sls_itmzr_06 { get; set; }
        public decimal? pms_sls_itmzr_07 { get; set; }
        public decimal? pms_sls_itmzr_08 { get; set; }
        public decimal? pms_tax_itmzr_01 { get; set; }
        public decimal? pms_tax_itmzr_02 { get; set; }
        public decimal? pms_tax_itmzr_03 { get; set; }
        public decimal? pms_tax_itmzr_04 { get; set; }
        public decimal? pms_tax_itmzr_05 { get; set; }
        public decimal? pms_tax_itmzr_06 { get; set; }
        public decimal? pms_tax_itmzr_07 { get; set; }
        public decimal? pms_tax_itmzr_08 { get; set; }
        public decimal? pms_item_dsc_itmzr { get; set; }
        public decimal? pms_sttl_dsc_itmzr { get; set; }
        public decimal? pms_svc_itmzr { get; set; }
        public decimal? pms_asvc_itmzr { get; set; }
        public int? pms_cov_cnt { get; set; }
    }
}
