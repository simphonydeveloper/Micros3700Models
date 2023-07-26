using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class infc_condition_def
    {
        public int infc_condition_seq { get; set; }
        public int? infc_col_seq { get; set; }
        public string condition { get; set; }
        public string value { get; set; }
    }
}
