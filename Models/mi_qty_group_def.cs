using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_qty_group_def
    {
        public int mi_qty_grp_def_seq { get; set; }
        public string name { get; set; }
        public int qty_for_activation { get; set; }
        public int qty_for_upsell_msg { get; set; }
        public int? tax_class_seq { get; set; }
        public int? discount_seq { get; set; }
    }
}
