using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{
    public class ProjectShow : Project
    {
        public string PlaceName { get; set; }
        public string ConstructUnitName { get; set; }
        public string DesignUnitName { get; set; }
        public string BuildStructName { get; set; }
        public string ReportConditionName { get; set; }
        public string SupervisorUnitName { get; set; }
        public string WorkStartDateName { get; set; }
        public string CheckDateName { get; set; }
        public string CreateDateName { get; set; }
    }
}
