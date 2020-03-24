using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.Equipment
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-21 14:28
    /// 描 述：设备管理实体类
    /// </summary>
    [Table("sys_equipmentinfo")]
    public class EquipmentinfoEntity : BaseEntity
    {
        /// <summary>
        /// 设备编号
        /// </summary>
        /// <returns></returns>
        public string Emnumber { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        /// <returns></returns>
        public string Emname { get; set; }
        /// <summary>
        /// 设备型号
        /// </summary>
        /// <returns></returns>
        public string Emtype { get; set; }
        /// <summary>
        /// 计量单位
        /// </summary>
        /// <returns></returns>
        public string Unit { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        /// <returns></returns>
        public string Emamount { get; set; }
        /// <summary>
        /// 设备参数
        /// </summary>
        /// <returns></returns>
        public string Emparameter { get; set; }
        /// <summary>
        /// 安装位置
        /// </summary>
        /// <returns></returns>
        public string Emlocation { get; set; }
        /// <summary>
        /// 所属设备
        /// </summary>
        /// <returns></returns>
        public string Emsuperior { get; set; }
        /// <summary>
        /// 所属系统
        /// </summary>
        /// <returns></returns>
        public string Emsystem { get; set; }
        /// <summary>
        /// 设备状态
        /// </summary>
        /// <returns></returns>
        public string Emstatus { get; set; }
        /// <summary>
        /// 设备类型
        /// </summary>
        /// <returns></returns>
        public string Emkind { get; set; }
        /// <summary>
        /// 设备标识
        /// </summary>
        /// <returns></returns>
        public string Emidentification { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        /// <returns></returns>
        public string Emmanufacturers { get; set; }
        /// <summary>
        /// 出厂时间
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? Emdeliverytime { get; set; }
        /// <summary>
        /// 出厂编号
        /// </summary>
        /// <returns></returns>
        public string Emmanufacturingnumber { get; set; }
        /// <summary>
        /// 安装日期
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? Eminstalltime { get; set; }
        /// <summary>
        /// 所属部门
        /// </summary>
        /// <returns></returns>
        public string Edepartment { get; set; }

        [NotMapped]
        public string DepartmentName { get; set; }
    }
}
