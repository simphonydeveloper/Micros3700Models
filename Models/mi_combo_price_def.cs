using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_combo_price_def
    {
        public int combo_menu_item_seq { get; set; }
        public int combo_mi_price_seq { get; set; }
        public int? price_grp_seq { get; set; }
        public int? price_tier_seq { get; set; }
        public decimal? em_chg_set_seq { get; set; }
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
    }
}
