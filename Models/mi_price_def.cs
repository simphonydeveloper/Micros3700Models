using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_price_def
    {
        public int mi_seq { get; set; }
        public int mi_price_seq { get; set; }
        public DateTime? effective_from { get; set; }
        public DateTime? effective_to { get; set; }
        public decimal? preset_amt_1 { get; set; }
        public decimal? preset_amt_2 { get; set; }
        public decimal? preset_amt_3 { get; set; }
        public decimal? preset_amt_4 { get; set; }
        public decimal? preset_amt_5 { get; set; }
        public decimal? preset_amt_6 { get; set; }
        public decimal? preset_amt_7 { get; set; }
        public decimal? preset_amt_8 { get; set; }
        public decimal? preset_amt_9 { get; set; }
        public decimal? preset_amt_10 { get; set; }
        public decimal? vat_txbl_1 { get; set; }
        public decimal? vat_txbl_2 { get; set; }
        public decimal? vat_txbl_3 { get; set; }
        public decimal? vat_txbl_4 { get; set; }
        public decimal? vat_txbl_5 { get; set; }
        public decimal? vat_txbl_6 { get; set; }
        public decimal? vat_txbl_7 { get; set; }
        public decimal? vat_txbl_8 { get; set; }
        public decimal? vat_txbl_9 { get; set; }
        public decimal? vat_txbl_10 { get; set; }
        public decimal? cost_1 { get; set; }
        public decimal? cost_2 { get; set; }
        public decimal? cost_3 { get; set; }
        public decimal? cost_4 { get; set; }
        public decimal? cost_5 { get; set; }
        public decimal? cost_6 { get; set; }
        public decimal? cost_7 { get; set; }
        public decimal? cost_8 { get; set; }
        public decimal? cost_9 { get; set; }
        public decimal? cost_10 { get; set; }
        public decimal? tare_weight { get; set; }
        public decimal? surcharge_tax { get; set; }
        public decimal? em_chg_set_seq { get; set; }
        public int? price_grp_seq { get; set; }
        public int? price_tier_seq { get; set; }
        public string em_repl_status { get; set; }
        public string comments { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public int? last_updated_by { get; set; }
        public string menu_panel_price_01 { get; set; }
        public string menu_panel_price_02 { get; set; }
        public string menu_panel_price_03 { get; set; }
        public string menu_panel_price_04 { get; set; }
        public string menu_panel_price_05 { get; set; }
        public string menu_panel_price_06 { get; set; }
        public string menu_panel_price_07 { get; set; }
        public string menu_panel_price_08 { get; set; }
        public string menu_panel_price_09 { get; set; }
        public string menu_panel_price_10 { get; set; }
    }
}
