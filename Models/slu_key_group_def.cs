using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class slu_key_group_def
    {
        public int slu_key_group_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? key_width { get; set; }
        public short? key_height { get; set; }
        public string key_arrangement { get; set; }
    }
}
