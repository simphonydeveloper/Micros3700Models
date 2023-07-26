using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class gss_gl_period_def
    {
        public int gl_period_seq { get; set; }
        public string name { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public string closed { get; set; }
    }
}
