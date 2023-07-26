using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_board_set_def
    {
        public int menu_board_set_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? dev_seq { get; set; }
        public DateTime? effective_from { get; set; }
        public DateTime? effective_to { get; set; }
    }
}
