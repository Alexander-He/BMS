using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{
    [Table("Project")]
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 工程名称
        /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
        /// 工程地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 所属地
        /// </summary>
        public int Place { get; set; }
        /// <summary>
        /// 建设单位
        /// </summary>
        public string BuildUnit { get; set; }
        /// <summary>
        /// 施工单位
        /// </summary>
        public int ConstructUnit { get; set; }
        /// <summary>
        /// 设计单位
        /// </summary>
        public int DesignUnit { get; set; }
        /// <summary>
        /// 建筑结构(搭建、框架、其它)
        /// </summary>
        public int BuildStruct { get; set; }
        /// <summary>
        /// 报建情况（未报建、未按规划施工、镇报建、市报建、已拆除、已补办）
        /// </summary>
        public int ReportCondition { get; set; }
        /// <summary>
        /// 监理单位
        /// </summary>
        public int SupervisorUnit { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string WorkChargre { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Contact { get; set; } 
        /// <summary>
        /// 工程概况
        /// </summary>
        public string ProjectDesc { get; set; } 
        /// <summary>
        /// 工程进度
        /// </summary>
        public string ProjectProgress { get; set; }
        /// <summary>
        /// 开工时间
        /// </summary>
        public DateTime WorkStartDate { get; set; }
        /// <summary>
        /// 检查时间
        /// </summary>
        public DateTime? CheckDate { get; set; }
        /// <summary>
        /// 建筑面积m^2/层数
        /// </summary>
        public string BuildArea { get; set; }
        /// <summary>
        /// 查处情况
        /// </summary>
        public string InvestigateCase { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }
    }


}
