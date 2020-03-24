using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Entity.Equipment;
using YiSha.Model.Param.Equipment;
using YiSha.Service.Equipment;

namespace YiSha.Business.Equipment
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-21 14:28
    /// 描 述：设备管理业务类
    /// </summary>
    public class EquipmentinfoBLL
    {
        private EquipmentinfoService equipmentinfoService = new EquipmentinfoService();

        #region 获取数据
        public async Task<TData<List<EquipmentinfoEntity>>> GetList(EquipmentinfoListParam param)
        {
            TData<List<EquipmentinfoEntity>> obj = new TData<List<EquipmentinfoEntity>>();
            obj.Result = await equipmentinfoService.GetList(param);
            obj.TotalCount = obj.Result.Count;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<List<EquipmentinfoEntity>>> GetPageList(EquipmentinfoListParam param, Pagination pagination)
        {
            TData<List<EquipmentinfoEntity>> obj = new TData<List<EquipmentinfoEntity>>();
            obj.Result = await equipmentinfoService.GetPageList(param, pagination);
            obj.TotalCount = pagination.TotalCount;
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData<EquipmentinfoEntity>> GetEntity(long id)
        {
            TData<EquipmentinfoEntity> obj = new TData<EquipmentinfoEntity>();
            obj.Result = await equipmentinfoService.GetEntity(id);
            if (obj.Result != null)
            {
                obj.Tag = 1;
            }
            return obj;
        }
        #endregion

        #region 提交数据
        public async Task<TData<string>> SaveForm(EquipmentinfoEntity entity)
        {
            TData<string> obj = new TData<string>();
            await equipmentinfoService.SaveForm(entity);
            obj.Result = entity.Id.ParseToString();
            obj.Tag = 1;
            return obj;
        }

        public async Task<TData> DeleteForm(string ids)
        {
            TData obj = new TData();
            await equipmentinfoService.DeleteForm(ids);
            obj.Tag = 1;
            return obj;
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
