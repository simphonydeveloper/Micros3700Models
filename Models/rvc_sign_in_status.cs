using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class rvc_sign_in_status
    {
        public int rvc_seq { get; set; }
        public int rvc_sign_in_seq { get; set; }
        public int? emp_seq { get; set; }
    }
}
