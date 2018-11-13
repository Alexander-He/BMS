using AutoMapper;
using BMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    public static class ExtensionMethod
    {
        public static int ToInt(this object value)
        {
            if (value != null)
            {
                int result = 0;
                if (int.TryParse(value.ToString(), out result))
                    return result;
            }
            return 0;
        } 
      
        public static ProjectShow ToShow(this Project project, List<PropertyMetadata> list)
        {
            ProjectShow result = Mapper.Map<Project, ProjectShow>(project);

            if (project.Place > 0)
                result.PlaceName = list.FirstOrDefault(x => x.Id == project.Place).Name;
            if (project.ConstructUnit > 0)
                result.ConstructUnitName = list.FirstOrDefault(x => x.Id == project.ConstructUnit).Name;
            if (project.DesignUnit > 0)
                result.DesignUnitName = list.FirstOrDefault(x => x.Id == project.DesignUnit).Name;
            if (project.BuildStruct > 0)
                result.BuildStructName = list.FirstOrDefault(x => x.Id == project.BuildStruct).Name;
            if (project.ReportCondition > 0)
                result.ReportConditionName = list.FirstOrDefault(x => x.Id == project.ReportCondition).Name;
            if (project.SupervisorUnit > 0)
                result.SupervisorUnitName = list.FirstOrDefault(x => x.Id == project.SupervisorUnit).Name;
            if (project.Place > 0)
                result.WorkStartDateName = project.WorkStartDate.ToString("yyyy-MM-dd");
            if (project.Place > 0)
                result.CheckDateName = project.CheckDate.HasValue ? project.CheckDate.Value.ToString("yyyy-MM-dd") : "";
            if (project.Place > 0)
                result.CreateDateName = project.CreateDate.ToString("yyyy-MM-dd");

            return result;

        }

    }
}
