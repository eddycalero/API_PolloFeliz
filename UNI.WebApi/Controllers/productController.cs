using Microsoft.AspNetCore.Mvc;
using UNI.Services;

namespace UNI.WebApi

{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager serviceManager;
        public ProductController( IServiceManager service)
        {
            serviceManager = service;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] SubCategoryDto subCategoryDto)
        {

            subCategoryDto = await serviceManager.SubCategoryService.CreateSubCategoryDto(subCategoryDto);

            return StatusCode(StatusCodes.Status201Created, subCategoryDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {

            List<SubCategoryDto> SubcategoryCreates = await serviceManager.SubCategoryService.GetSubCategory();

            return StatusCode(StatusCodes.Status200OK, SubcategoryCreates);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            bool SubcategoryDelete = await serviceManager.SubCategoryService.DeleteSubCategory(id);

            return StatusCode(StatusCodes.Status200OK, SubcategoryDelete);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] SubCategoryDto createDto)
        {

            SubCategoryDto SubcategoryUpdate = await serviceManager.SubCategoryService.UpdateSubCategory(id, createDto);

            return StatusCode(StatusCodes.Status200OK, SubcategoryUpdate);
        }
    }
}
