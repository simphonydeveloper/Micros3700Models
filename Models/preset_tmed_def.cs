using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class preset_tmed_def
    {
        public int tmed_seq { get; set; }
        public int preset_tender_amt_seq { get; set; }
        public string name { get; set; }
        public decimal? amt { get; set; }
        public short? nlu_num { get; set; }
        public int? key_num { get; set; }
        public int? tmed_slu_seq { get; set; }
        public int? last_updated_by { get; set; }
    }
}
