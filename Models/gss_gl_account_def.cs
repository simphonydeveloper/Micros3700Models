using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gl_account_def
    {
        public int gl_account_seq { get; set; }
        public string number { get; set; }
        public string name { get; set; }
    }
}
