using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_count_item_mbr_dtl
    {
        public int count_seq { get; set; }
        public int count_item_seq { get; set; }
        public string ob_on_countsheet { get; set; }
    }
}
