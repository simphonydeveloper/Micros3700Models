using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class smart_key_group_def
    {
        public int smart_key_group_seq { get; set; }
        public int obj_num { get; set; }
        public string name { get; set; }
        public short? rule_type { get; set; }
        public short? operator_type { get; set; }
    }
}
