using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository efCategoryRespository;

        public CategoryManager()
        {
            efCategoryRespository = new EfCategoryRepository();
        }

        public void CategoryAdd(Category category)
        {

            efCategoryRespository.Insert(category);

        }

        public void CategoryDelete(Category category)
        {
            efCategoryRespository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            efCategoryRespository.Update(category);
        }

        public Category GetbyId(int id)
        {
            return efCategoryRespository.GetbyId(id);
        }

        public List<Category> GetList()
        {
            return efCategoryRespository.GetListAll();
        }
    }
}
