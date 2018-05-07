using JProject.IDAL;
using JProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.DAL
{
    public class SysSampleRepository : ISysSampleRepository, IDisposable
    {
        /// <summary>
        /// 创建数据实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(SysSample entity)
        {
            using (JProjectDBEntities db = new JProjectDBEntities())
            {
                db.Set<SysSample>().Add(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(string id)
        {
            using (JProjectDBEntities db = new JProjectDBEntities())
            {
                SysSample entity = db.SysSample.SingleOrDefault(a => a.Id == id);
                db.Set<SysSample>().Remove(entity);
                return db.SaveChanges();
            }
        }
        /// <summary>
        ///
        /// </summary>
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Edit(SysSample entity)
        {
            using (JProjectDBEntities db = new JProjectDBEntities())
            {
                db.Set<SysSample>().Attach(entity);
                db.Entry<SysSample>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 根据id获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SysSample GetById(string id)
        {
            using (JProjectDBEntities db = new JProjectDBEntities())
            {
                return db.SysSample.SingleOrDefault(a => a.Id == id);
            }
        }
        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="db"></param>
        /// <returns></returns>
        public IQueryable<SysSample> GetList(JProjectDBEntities db)
        {
            IQueryable<SysSample> list = db.SysSample.AsQueryable();
            return list;
        }
        /// <summary>
        /// 根据id判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExist(string id)
        {
            using (JProjectDBEntities db = new JProjectDBEntities())
            {
                SysSample entity = GetById(id);
                if (entity != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
