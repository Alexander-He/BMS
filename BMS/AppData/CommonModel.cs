using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS
{
    public enum MetaDataType
    {
        /// <summary>
        /// 所属地
        /// </summary>
        [Description("所属地")]
        Place,
        /// <summary>
        /// 建筑结构
        /// </summary>
        [Description("建筑结构")]
        BuildStruct,
        /// <summary>
        /// 报建情况
        /// </summary>
        [Description("报建情况")]
        ReportCondition,
        /// <summary>
        /// 施工单位
        /// </summary>
        [Description("施工单位")]
        ConstructUnit,
        /// <summary>
        /// 设计单位
        /// </summary>
        [Description("设计单位")]
        DesignUnit,
        /// <summary>
        /// 监理单位
        /// </summary>
        [Description("监理单位")]
        SupervisorUnit
    }
}
