using Project5_DapperNorthwind.DTOS.CategoryDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Repositories.CategoryRepositories
{
    public class CategoryRepositories : IcategoryRepo
    {
        public Task createCategoryAsync(CreateCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task deleteCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<List<CategoryDto>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task updateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
