using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_pc_template_def
    {
        public int pc_template_seq { get; set; }
        public string pc_template_name { get; set; }
        public decimal? min_balance { get; set; }
        public decimal? max_balance { get; set; }
        public int? countsheet_seq { get; set; }
    }
}
