using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class prod_sht_mem_def
    {
        public int prod_sht_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public int? unit_seq { get; set; }
        public short? prn_sort_ordr { get; set; }
        public string cmnt_ln { get; set; }
        public short? rcp_book_pg_num_ovrde { get; set; }
        public string spreadsheet_filename_ovrde { get; set; }
        public short? stat { get; set; }
        public int? last_updated_by { get; set; }
        public DateTime? last_updated_date { get; set; }
    }
}
