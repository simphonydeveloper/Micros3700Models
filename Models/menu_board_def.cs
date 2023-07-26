using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class menu_board_def
    {
        public int menu_board_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public int? prd_seq { get; set; }
        public string main_html { get; set; }
        public string board_html { get; set; }
        public short? num_panels { get; set; }
        public string manually_set { get; set; }
        public int? menu_board_set_seq { get; set; }
    }
}
