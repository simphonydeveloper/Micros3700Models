using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class production_item_def
    {
        public int production_item_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? shelf_life { get; set; }
        public int? scheme_seq { get; set; }
    }
}
