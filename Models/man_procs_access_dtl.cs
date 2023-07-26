using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Micros3700Models.Models
{
    public class man_procs_access_dtl
    {
        public string SessionID { get; set; }
        public int EmpSeq { get; set; }
        public int? EmpClass { get; set; }
        public string OpsStart { get; set; }
        public DateTime? LoggedIn { get; set; }
        public int? LMLevel { get; set; }
        public int? POSType { get; set; }
        public string IsBravo { get; set; }
        public int? EmployeeAccessLevel { get; set; }
        public int? EmployeePrivLevel { get; set; }
        public string AllowEmpAssign { get; set; }
        public string AllowSetTraining { get; set; }
        public string AllowPrinterRedir { get; set; }
        public string AllowMIAssign { get; set; }
        public string AllowAdjustTimecard { get; set; }
        public string AllowMIAvail { get; set; }
        public string AllowSetCurrency { get; set; }
        public string AllowSetBusDate { get; set; }
        public string AllowChangeEmpShift { get; set; }
        public string AllowChangeCshrShift { get; set; }
        public string AllowFullMIAccess { get; set; }
        public string AllowFullEmpAccess { get; set; }
        public string AllowFormsDesigner { get; set; }
        public string AllowTableAssign { get; set; }
        public string AllowSetSUStatus { get; set; }
        public string AllowAddDelete { get; set; }
        public string AllowSrvPrdOtherRVC { get; set; }
        public string AllowSetKitchenTheme { get; set; }
        public string AllowSetSrvPrd { get; set; }
        public string AllowClearAllTotals { get; set; }
        public string AllowAddNewEmployee { get; set; }
        public string AllowScheduleTimecard { get; set; }
        public string Unused1 { get; set; }
        public string Unused2 { get; set; }
        public string Unused3 { get; set; }
        public string Unused4 { get; set; }
        public string Unused5 { get; set; }
        public string LogPerformance { get; set; }
        public string UserLoggedOn { get; set; }
        public string PerfLogDir { get; set; }
        public string ClientName { get; set; }
        public string AllowDashboard { get; set; }
        public string ViewDashboardSales { get; set; }
        public string ViewDashboardKitchen { get; set; }
        public string ViewDashboardLabor { get; set; }
        public string ViewDashboardEmployee { get; set; }
        public string ViewDashboardContest { get; set; }
        public string EditDashboardContest { get; set; }
    }
}
