using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class combo_menu_item_def
    {
        public int combo_menu_item_seq { get; set; }
        public int? combo_grp_seq { get; set; }
        public int? mi_seq { get; set; }
        public int? quantity { get; set; }
        public string ob_default { get; set; }
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
        public string ob_ot01_default { get; set; }
        public string ob_ot02_default { get; set; }
        public string ob_ot03_default { get; set; }
        public string ob_ot04_default { get; set; }
        public string ob_ot05_default { get; set; }
        public string ob_ot06_default { get; set; }
        public string ob_rsvd01 { get; set; }
        public string ob_rsvd02 { get; set; }
        public string ob_rsvd03 { get; set; }
        public string ob_rsvd04 { get; set; }
        public string ob_rsvd05 { get; set; }
        public string ob_rsvd06 { get; set; }
        public string ob_rsvd07 { get; set; }
        public DateTime? effective_from { get; set; }
        public DateTime? effective_to { get; set; }
        public int? size_1 { get; set; }
        public int? size_2 { get; set; }
        public int? size_3 { get; set; }
        public int? size_4 { get; set; }
        public short? size_1_price_lvl { get; set; }
        public short? size_2_price_lvl { get; set; }
        public short? size_3_price_lvl { get; set; }
        public short? size_4_price_lvl { get; set; }
        public int? print_class_seq { get; set; }
        public string ob_ot07_default { get; set; }
        public string ob_ot08_default { get; set; }
        public string ob_ot09_default { get; set; }
        public string ob_ot10_default { get; set; }
        public string ob_ot11_default { get; set; }
        public string ob_ot12_default { get; set; }
    }
}
