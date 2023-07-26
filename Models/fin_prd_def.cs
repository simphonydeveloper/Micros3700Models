using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_prd_def
    {
        public int fin_prd_seq { get; set; }
        public int fin_config_seq { get; set; }
        public int fin_year_seq { get; set; }
        public DateTime begin_date { get; set; }
        public DateTime end_date { get; set; }
        public string name { get; set; }
        public string closed { get; set; }
        public DateTime? closed_date { get; set; }
        public string week_end { get; set; }
        public string month_end { get; set; }
        public string quarter_end { get; set; }
        public string year_end { get; set; }
        public string ob_consolidate { get; set; }
    }
}
