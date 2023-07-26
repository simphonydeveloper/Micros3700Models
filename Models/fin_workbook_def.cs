using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class fin_workbook_def
    {
        public int fin_workbook_seq { get; set; }
        public int fin_config_seq { get; set; }
        public int effective_from_prd { get; set; }
        public int? effective_to_prd { get; set; }
        public string workbook { get; set; }
        public string stored_proc1 { get; set; }
        public string stored_proc2 { get; set; }
        public string stored_proc3 { get; set; }
        public string stored_proc4 { get; set; }
        public string stored_proc5 { get; set; }
        public string stored_proc6 { get; set; }
        public string stored_proc7 { get; set; }
        public string stored_proc8 { get; set; }
        public int? copy_num { get; set; }
        public string start_cell { get; set; }
        public string show_grid { get; set; }
        public string report_cell1 { get; set; }
        public string report_title1 { get; set; }
        public string report_cell2 { get; set; }
        public string report_title2 { get; set; }
        public string report_cell3 { get; set; }
        public string report_title3 { get; set; }
        public string report_cell4 { get; set; }
        public string report_title4 { get; set; }
        public string report_cell5 { get; set; }
        public string report_title5 { get; set; }
        public string report_cell6 { get; set; }
        public string report_title6 { get; set; }
        public string report_cell7 { get; set; }
        public string report_title7 { get; set; }
        public string report_cell8 { get; set; }
        public string report_title8 { get; set; }
        public string rsvd_01 { get; set; }
    }
}
