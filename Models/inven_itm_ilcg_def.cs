using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class inven_itm_ilcg_def
    {
        public int inven_itm_ilcg_seq { get; set; }
        public int? sort_ordr { get; set; }
        public string ob_dflt { get; set; }
        public int ilcg_seq { get; set; }
        public int inven_itm_seq { get; set; }
    }
}
