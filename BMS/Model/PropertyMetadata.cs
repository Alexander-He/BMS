using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.Model
{
    [Table("PropertyMetadata")]
    public class PropertyMetadata
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [Column("Name")]
        public string Name { get; set; }
        /// <summary>
        /// 名称(所属地、设计单位、施工单位、监理单位）
        /// </summary>
        [Column("Type")]
        public string Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Column("Remark")]
        public string Remark { get; set; }

    }
}
