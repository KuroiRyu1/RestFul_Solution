using RestFul_1.Models.entity;
using RestFul_1.Models.ModelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestFul_1.Models.Repositories
{
    public class CategoryRes
    {
        public List<Category> Gets()
        {
            List<Category> list = new List<Category>();
            try
            {
                DbEntities entities = new DbEntities();
                list = entities.tbl_category.Select(d => new Category
                {
                    Id = d.C_id,
                    Name = d.C_name,
                    Active = d.C_active ?? 0,
                }).ToList();
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public void Create(Category item)
        {
            try
            {
                DbEntities entity = new DbEntities();
                var cate = new tbl_category { 
                    C_name = item.Name, 
                    C_active = item.Active 
                };
                entity.tbl_category.Add(cate);
                entity.SaveChanges();
                item.Id = cate.C_id;

            }
            catch (Exception ex)
            {
            }
        }
    }
}