using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class foreign_key_tree_temp
    {
        public int seq { get; set; }
        public short? foreign_table_id { get; set; }
        public short? foreign_key_id { get; set; }
        public short parent_id { get; set; }
        public short? child_id { get; set; }
        public string fk_nullablity { get; set; }
    }
}
