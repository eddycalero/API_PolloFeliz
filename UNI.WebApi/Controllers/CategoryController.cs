using Microsoft.AspNetCore.Mvc;
using UNI.Services;

namespace UNI.WebApi

{
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager serviceManager;
        public CategoryController( IServiceManager service)
        {
            serviceManager = service;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryCreateDto categoryCreateDto)
        {

            categoryCreateDto = await serviceManager.CategoryService.CreateCategoryDto(categoryCreateDto);

            return StatusCode(StatusCodes.Status201Created, categoryCreateDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {

            List<CategoryCreateDto> categoryCreates = await serviceManager.CategoryService.GetAllCategories();

            return StatusCode(StatusCodes.Status200OK, categoryCreates);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            bool categoryDelete = await serviceManager.CategoryService.DeleteCategoryById(id);

            return StatusCode(StatusCodes.Status200OK, categoryDelete);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] CategoryCreateDto createDto)
        {

            CategoryCreateDto categoryUpdate = await serviceManager.CategoryService.UpdateCategory(id, createDto);

            return StatusCode(StatusCodes.Status200OK, categoryUpdate);
        }
    }
}
