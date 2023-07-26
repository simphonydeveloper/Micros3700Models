using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class period_temp
    {
        public DateTime business_date { get; set; }
        public int prd_seq { get; set; }
        public int time_period_seq { get; set; }
        public DateTime start_tm { get; set; }
        public DateTime end_tm { get; set; }
    }
}
