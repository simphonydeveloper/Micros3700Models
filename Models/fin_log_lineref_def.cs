using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_log_lineref_def
    {
        public int fin_log_lineref_seq { get; set; }
        public string name { get; set; }
        public string obsolete { get; set; }
        public string acct_grp { get; set; }
    }
}
