using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_highlight_scheme_def
    {
        public int scheme_seq { get; set; }
        public string name { get; set; }
        public decimal? foreground { get; set; }
        public decimal? background { get; set; }
    }
}
