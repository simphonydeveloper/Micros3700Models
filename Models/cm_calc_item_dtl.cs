using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_calc_item_dtl
    {
        public int cm_item_seq { get; set; }
        public int component_item_seq { get; set; }
        public int? item_operation { get; set; }
    }
}
