using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cncy_col_maint_def
    {
        public int def_seq { get; set; }
        public int foreign_tbl { get; set; }
        public int foreign_cncy_col { get; set; }
        public int base_tbl { get; set; }
        public int base_cncy_col { get; set; }
    }
}
