using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_status
    {
        public int mi_seq { get; set; }
        public short? available_count { get; set; }
        public string ob_mi32_out_of_mi { get; set; }
        public decimal? theoretical_cost_1 { get; set; }
        public decimal? theoretical_cost_2 { get; set; }
        public decimal? theoretical_cost_3 { get; set; }
        public decimal? theoretical_cost_4 { get; set; }
    }
}
