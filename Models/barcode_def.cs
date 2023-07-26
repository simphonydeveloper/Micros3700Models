using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class barcode_def
    {
        public int barcode_seq { get; set; }
        public int? mi_seq { get; set; }
        public string barcode_type { get; set; }
        public string barcode { get; set; }
        public int obj_num { get; set; }
        public decimal? price { get; set; }
        public decimal? cost { get; set; }
        public short? mi_price_level { get; set; }
    }
}
