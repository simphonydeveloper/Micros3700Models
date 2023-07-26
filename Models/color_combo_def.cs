using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class color_combo_def
    {
        public int color_scheme_seq { get; set; }
        public int color_combo_seq { get; set; }
        public decimal? foreground { get; set; }
        public decimal? background { get; set; }
        public decimal? inv_foreground { get; set; }
        public decimal? inv_background { get; set; }
        public int? last_updated_by { get; set; }
    }
}
