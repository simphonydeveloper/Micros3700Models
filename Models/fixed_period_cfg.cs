using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fixed_period_cfg
    {
        public int fixed_period_seq { get; set; }
        public string name { get; set; }
        public short? start_time { get; set; }
        public short? end_time { get; set; }
    }
}
