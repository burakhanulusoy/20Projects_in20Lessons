using Project5_DapperNorthwind.DTOS.CategoryDTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Repositories.CategoryRepositories
{
    internal interface IcategoryRepo
    {

        Task<List<CategoryDto>> GetAllCategoriesAsync();//listele
        Task createCategoryAsync(CreateCategoryDto categoryDto);//ekle
        Task updateCategoryAsync(UpdateCategoryDto updateCategoryDto);//güncelle
        Task deleteCategoryAsync(int categoryId);// sil
        Task<GetByIdCategoryDto> GetByIdCategoryAsync(int categoryId);//ara
    }
}
