using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class cm_currency_def
    {
        public int cm_currency_seq { get; set; }
        public string currency_name { get; set; }
        public int? res_currency_id { get; set; }
        public string three_letter_abrv { get; set; }
    }
}
