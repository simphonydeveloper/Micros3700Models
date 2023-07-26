using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class mi_product_status
    {
        public int mi_seq { get; set; }
        public int menu_lvl { get; set; }
        public int ilcg_seq { get; set; }
        public double? theo_cost { get; set; }
    }
}
