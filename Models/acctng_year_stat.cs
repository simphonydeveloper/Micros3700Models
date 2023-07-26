using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class acctng_year_stat
    {
        public int acctng_year_seq { get; set; }
        public DateTime? close_date { get; set; }
    }
}
