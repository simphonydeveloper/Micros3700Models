using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_prod_def
    {
        public int inven_itm_seq { get; set; }
        public short? prod_lab_hrs { get; set; }
        public short? prod_lab_minute { get; set; }
        public short? prod_srv_hrs { get; set; }
        public short? prod_srv_minute { get; set; }
        public decimal? thaw_from_hrs { get; set; }
        public short? thaw_from_day { get; set; }
        public decimal? thaw_to_hrs { get; set; }
        public short? thaw_to_day { get; set; }
    }
}
