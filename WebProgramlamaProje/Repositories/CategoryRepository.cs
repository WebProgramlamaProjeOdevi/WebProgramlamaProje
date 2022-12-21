using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
	public class CategoryRepository:GenericRepository<Category>
	{

        public int AddCategory(Category p)
        {
            CategoryRepository categoryRepository= new CategoryRepository();
            if (p.CategoryName == "")
            {
                return -1;
            }
            return categoryRepository.TAdd(p);
        }

        public int DeleteCategory(int p)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            Category category = categoryRepository.Find(x => x.CategoryID == p);
            return categoryRepository.TDelete(category);
        }

        public Category FindCategory(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            return categoryRepository.Find(x => x.CategoryID == id);
        }
        public int EditCategory(Category p)
        {
            CategoryRepository categoryRepository = new CategoryRepository();

            Category category = categoryRepository.Find(x => x.CategoryID == p.CategoryID);
            category.CategoryName = p.CategoryName;  
            return categoryRepository.TUpdate(category);
        }
    }
}
