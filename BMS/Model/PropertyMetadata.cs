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
        public Int64 Id { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required] 
        public string Name { get; set; }
        /// <summary>
        /// Type
        /// </summary> 
        public string Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary> 
        public string Remark { get; set; }

    }
}
