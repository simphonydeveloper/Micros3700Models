using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_barcode_def
    {
        public int inven_barcode_seq { get; set; }
        public int inven_itm_seq { get; set; }
        public int unit_seq { get; set; }
        public string barcode { get; set; }
        public string description { get; set; }
    }
}
