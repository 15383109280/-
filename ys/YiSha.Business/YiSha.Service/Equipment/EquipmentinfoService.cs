using System;
using System.Linq;
using System.Text;
using System.Data.Common;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using YiSha.Util;
using YiSha.Util.Extension;
using YiSha.Util.Model;
using YiSha.Data;
using YiSha.Data.Repository;
using YiSha.Entity.Equipment;
using YiSha.Model.Param.Equipment;

namespace YiSha.Service.Equipment
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2020-03-21 14:28
    /// 描 述：设备管理服务类
    /// </summary>
    public class EquipmentinfoService :  RepositoryFactory
    {
        #region 获取数据
        public async Task<List<EquipmentinfoEntity>> GetList(EquipmentinfoListParam param)
        {
            var expression = ListFilter(param);
            var list = await this.BaseRepository().FindList(expression);
            return list.ToList();
        }

        public async Task<List<EquipmentinfoEntity>> GetPageList(EquipmentinfoListParam param, Pagination pagination)
        {
            var expression = ListFilter(param);
            var list= await this.BaseRepository().FindList(expression, pagination);
            return list.ToList();
        }

        public async Task<EquipmentinfoEntity> GetEntity(long id)
        {
            return await this.BaseRepository().FindEntity<EquipmentinfoEntity>(id);
        }
        #endregion

        #region 提交数据
        public async Task SaveForm(EquipmentinfoEntity entity)
        {
            if (entity.Id.IsNullOrZero())
            {
                entity.Create();
                await this.BaseRepository().Insert(entity);
            }
            else
            {
                
                await this.BaseRepository().Update(entity);
            }
        }

        public async Task DeleteForm(string ids)
        {
            long[] idArr = TextHelper.SplitToArray<long>(ids, ',');
            await this.BaseRepository().Delete<EquipmentinfoEntity>(idArr);
        }
        #endregion

        #region 私有方法
        private Expression<Func<EquipmentinfoEntity, bool>> ListFilter(EquipmentinfoListParam param)
        {
            var expression = LinqExtensions.True<EquipmentinfoEntity>();
            if (param != null)
            {
                if (!string.IsNullOrEmpty(param.Emnumber))
                {
                    expression = expression.And(t => t.Emnumber.Contains(param.Emnumber));
                }
                if (!string.IsNullOrEmpty(param.Emname))
                {
                    expression = expression.And(t => t.Emname.Contains(param.Emname));
                }
            }
            return expression;
        }
        #endregion
    }
}
