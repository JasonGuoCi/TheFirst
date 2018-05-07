using JProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.IDAL
{
    public interface ISysSampleRepository
    {
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        IQueryable<SysSample> GetList(JProjectDBEntities db);
        /// <summary>
        /// 创建数据
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        int Create(SysSample entity);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="id">数据ID</param>
        /// <returns></returns>
        int Delete(string id);
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Edit(SysSample entity);
        /// <summary>
        /// 根据id获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SysSample GetById(string id);
        /// <summary>
        ///根据ID判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExist(string id);
    }
}
