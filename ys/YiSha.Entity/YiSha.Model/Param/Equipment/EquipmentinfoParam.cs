using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Util;

namespace YiSha.Model.Param.Equipment
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-21 14:28
    /// 描 述：设备管理实体查询类
    /// </summary>
    public class EquipmentinfoListParam
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
        /// 所属部门
        /// </summary>
        /// <returns></returns>

    }
}
