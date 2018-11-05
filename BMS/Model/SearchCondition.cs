using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{
    public class SearchCondition
    {
        public string Keyword { get; set; }
        public DateTime? CheckDateStart { get; set; }
        public DateTime? CheckDateEnd { get; set; }
        public int Place { get; set; }
        public int BuildStruct { get; set; }
        public int ReportCondition { get; set; }
        public string ProjectName { get; set; }
        public string InvestigateCase { get; set; }
        public string Remark { get; set; }
    }
}
