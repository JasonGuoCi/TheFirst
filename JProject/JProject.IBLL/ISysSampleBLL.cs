using JProject.Common;
using JProject.Models;
using JProject.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.IBLL
{
    public interface ISysSampleBLL
    {
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="pager">JQGrid分页</param>
        /// <param name="queryStr">搜索条件</param>
        /// <returns></returns>
        //List<SysSampleModel> GetList(ref GridPager pager, string queryStr);
        List<SysSample> GetList(string queryStr);

        /// <summary>
        /// 创建数据
        /// </summary>
        /// <param name="errors">错误</param>
        /// <param name="model">模型</param>
        /// <returns></returns>
        bool Create(ref ValidationErrors errors, SysSampleModel model);

        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool Delete(string id);

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool Edit(SysSampleModel model);

        /// <summary>
        /// 根据ID判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool IsExist(string id);

        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        SysSampleModel GetById(string id);
    }
}
