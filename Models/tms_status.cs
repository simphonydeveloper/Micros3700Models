using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class tms_status
    {
        public int tms_seq { get; set; }
        public int? trans_seq { get; set; }
    }
}
