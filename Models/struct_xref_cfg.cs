using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class struct_xref_cfg
    {
        public int struct_seq { get; set; }
        public string table_name { get; set; }
        public string struct_name { get; set; }
        public string primary_flag { get; set; }
        public string secondary_select { get; set; }
    }
}
