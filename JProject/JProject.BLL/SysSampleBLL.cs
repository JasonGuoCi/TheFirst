using JProject.Common;
using JProject.DAL;
using JProject.IBLL;
using JProject.IDAL;
using JProject.Models;
using JProject.Models.Sys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    public class SysSampleBLL : ISysSampleBLL
    {
        JProjectDBEntities db = new JProjectDBEntities();

        //[Dependency]
        //public ISysSampleRepository Rep { get; set; }
        ISysSampleRepository Rep = new SysSampleRepository();

        /// <summary>
        /// 创建数据
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Create(ref ValidationErrors errors, SysSampleModel model)
        {
            try
            {
                SysSample entity = Rep.GetById(model.Id);
                if (entity == null)
                {
                    errors.Add("主键重复");
                    return false;
                }

                entity = new SysSample();
                entity.Id = model.Id;
                entity.Name = model.Name;
                entity.Note = model.Note;
                entity.Photo = model.Photo;
                entity.CreateTime = model.CreateTime;
                entity.Age = model.Age;
                entity.Bir = model.Bir;

                if (Rep.Create(entity) == 1)
                {
                    return true;
                }
                else
                {
                    errors.Add("插入失败");
                    return false;
                }
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 根据ID删除数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            try
            {
                if (Rep.Delete(id) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Edit(SysSampleModel model)
        {
            try
            {
                SysSample entity = Rep.GetById(model.Id);
                if (entity == null)
                {
                    return false;
                }
                entity.Name = model.Name;
                entity.Note = model.Note;
                entity.Photo = model.Photo;
                entity.Age = model.Age;
                entity.Bir = model.Bir;

                if (Rep.Edit(entity) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        /// <summary>
        /// 根据ID获取数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public SysSampleModel GetById(string id)
        {
            if (IsExist(id))
            {
                SysSample entity = Rep.GetById(id);
                SysSampleModel model = new SysSampleModel();
                model.Id = entity.Id;
                model.Name = entity.Name;
                model.Note = entity.Note;
                model.Photo = entity.Photo;
                model.Age = entity.Age;
                model.Bir = entity.Bir;
                model.CreateTime = entity.CreateTime;

                return model;
            }
            else
            {
                return new SysSampleModel();
            }
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="queryStr"></param>
        /// <returns></returns>
        /*
        public List<SysSampleModel> GetList(ref GridPager pager, string queryStr)
        {
            IQueryable<SysSample> queryData = Rep.GetList(db);
            if (!string.IsNullOrWhiteSpace(queryStr))
            {
                queryData = queryData.Where(a => a.Id.Contains(queryStr) || a.Name.Contains(queryStr) || a.Note.Contains(queryStr));
            }
            //排序
            if (pager.order == "desc")
            {
                switch (pager.sort)
                {
                    case "CreateTime":
                        queryData = queryData.OrderByDescending(a => a.CreateTime);
                        break;
                    case "Name":
                        queryData = queryData.OrderByDescending(a => a.Name);
                        break;
                    default:
                        queryData = queryData.OrderByDescending(a => a.CreateTime);
                        break;
                }
            }
            else
            {
                switch (pager.sort)
                {
                    case "CreateTime":
                        queryData = queryData.OrderBy(a => a.CreateTime);
                        break;
                    case "Name":
                        queryData = queryData.OrderBy(a => a.Name);
                        break;
                    default:
                        queryData = queryData.OrderBy(a => a.CreateTime);
                        break;
                }
            }

            return CreateModelList(ref pager, ref queryData);
        }
        */
        public List<SysSample> GetList(string queryStr)
        {
            IQueryable<SysSample> queryData = Rep.GetList(db);
            //if (!string.IsNullOrWhiteSpace(queryStr))
            //{
            //    queryData = queryData.Where(a => a.Id.Contains(queryStr) || a.Name.Contains(queryStr) || a.Note.Contains(queryStr));
            //}

            return queryData.ToList();
        }
        /// <summary>
        /// 生成SysSampleModel list
        /// </summary>
        /// <param name="pager"></param>
        /// <param name="queryData"></param>
        /// <returns></returns>
        private List<SysSampleModel> CreateModelList(ref GridPager pager, ref IQueryable<SysSample> queryData)
        {
            pager.totalRows = queryData.Count();
            if (pager.totalRows > 0)
            {
                if (pager.page <= 1)
                {
                    queryData = queryData.Take(pager.rows);
                }
                else
                {
                    queryData = queryData.Skip((pager.page - 1) * pager.rows).Take(pager.rows);
                }
            }
            List<SysSampleModel> modelList = (from r in queryData
                                              select new SysSampleModel
                                              {
                                                  Id = r.Id,
                                                  Name = r.Name,
                                                  Age = r.Age,
                                                  Bir = r.Bir,
                                                  Photo = r.Photo,
                                                  Note = r.Note,
                                                  CreateTime = r.CreateTime,
                                              }).ToList();
            return modelList;
        }

        /// <summary>
        /// 判断数据是否存在
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool IsExist(string id)
        {
            return Rep.IsExist(id);
        }
    }
}
