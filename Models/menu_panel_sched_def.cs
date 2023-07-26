using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_panel_sched_def
    {
        public int menu_panel_sched_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int prd_seq { get; set; }
        public int menu_board_seq { get; set; }
        public short? panel_num { get; set; }
        public int menu_panel_seq { get; set; }
    }
}
