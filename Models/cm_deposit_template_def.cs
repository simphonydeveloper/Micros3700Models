using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_deposit_template_def
    {
        public int deposit_template_seq { get; set; }
        public string deposit_name { get; set; }
        public string reference_data { get; set; }
    }
}
