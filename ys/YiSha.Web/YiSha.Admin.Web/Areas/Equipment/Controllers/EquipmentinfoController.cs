using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using YiSha.Util;
using YiSha.Util.Model;
using YiSha.Entity;
using YiSha.Model;
using YiSha.Admin.Web.Controllers;
using YiSha.Entity.Equipment;
using YiSha.Business.Equipment;
using YiSha.Model.Param.Equipment;

namespace YiSha.Admin.Web.Areas.Equipment.Controllers
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-21 14:28
    /// 描 述：设备管理控制器类
    /// </summary>
    [Area("Equipment")]
    public class EquipmentinfoController :  BaseController
    {
        private EquipmentinfoBLL equipmentinfoBLL = new EquipmentinfoBLL();

        #region 视图功能
        [AuthorizeFilter("equipment:equipmentinfo:view")]
        public ActionResult EquipmentinfoIndex()
        {
            return View();
        }

        public ActionResult EquipmentinfoForm()
        {
            return View();
        }
        #endregion

        #region 获取数据
        [HttpGet]
        [AuthorizeFilter("equipment:equipmentinfo:search")]
        public async Task<ActionResult> GetListJson(EquipmentinfoListParam param)
        {
            TData<List<EquipmentinfoEntity>> obj = await equipmentinfoBLL.GetList(param);
            return Json(obj);
        }

        [HttpGet]
        [AuthorizeFilter("equipment:equipmentinfo:search")]
        public async Task<ActionResult> GetPageListJson(EquipmentinfoListParam param, Pagination pagination)
        {

            TData<List<EquipmentinfoEntity>> obj = await equipmentinfoBLL.GetPageList(param, pagination);
           return Json(obj);
        }

        [HttpGet]
        public async Task<ActionResult> GetFormJson(long id)
        {
            TData<EquipmentinfoEntity> obj = await equipmentinfoBLL.GetEntity(id);
            return Json(obj);
        }
        #endregion

        #region 提交数据
        [HttpPost]
        [AuthorizeFilter("equipment:equipmentinfo:add,equipment:equipmentinfo:edit")]
        public async Task<ActionResult> SaveFormJson(EquipmentinfoEntity entity)
        {
            TData<string> obj = await equipmentinfoBLL.SaveForm(entity);
            return Json(obj);
        }

        [HttpPost]
        [AuthorizeFilter("equipment:equipmentinfo:delete")]
        public async Task<ActionResult> DeleteFormJson(string ids)
        {
            TData obj = await equipmentinfoBLL.DeleteForm(ids);
            return Json(obj);
        }
        #endregion
    }
}
