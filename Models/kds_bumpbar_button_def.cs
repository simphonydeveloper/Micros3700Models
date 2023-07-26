using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class kds_bumpbar_button_def
    {
        public int kds_bumpbar_seq { get; set; }
        public int keycode { get; set; }
        public int kds_button_seq { get; set; }
        public int? last_updated_by { get; set; }
    }
}
