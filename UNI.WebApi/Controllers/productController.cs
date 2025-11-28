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
        public async Task<IActionResult> CreateCategory([FromBody] ProductCreateDto subCategoryDto)
        {

            subCategoryDto = await serviceManager.ProductService.CreateProductDto(subCategoryDto);

            return StatusCode(StatusCodes.Status201Created, subCategoryDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            dynamic SubcategoryCreates = await serviceManager.ProductService.GetAllProduct();
            return StatusCode(StatusCodes.Status200OK, SubcategoryCreates);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {

            bool SubcategoryDelete = await serviceManager.SubCategoryService.DeleteSubCategory(id);

            return StatusCode(StatusCodes.Status200OK, SubcategoryDelete);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateCategory(int id, [FromBody] ProductCreateDto createDto)
        {

            createDto = await serviceManager.ProductService.UpdateProduct(id, createDto);

            return StatusCode(StatusCodes.Status200OK, createDto);
        }
    }
}
