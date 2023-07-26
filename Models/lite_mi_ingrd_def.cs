using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class lite_mi_ingrd_def
    {
        public int ingrd_seq { get; set; }
        public int mi_seq { get; set; }
        public int price_level { get; set; }
        public decimal? quantity { get; set; }
    }
}
