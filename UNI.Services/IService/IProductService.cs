namespace UNI.Services.IService
{
    public interface IProductService
    {
        public Task<ProductCreateDto> CreateProductDto(ProductCreateDto ProductCreateDto);
        public Task<List<ProductCreateDto>> GetAllProduct();
        public Task<ProductCreateDto> GetProductById(int id);
        public Task<bool> DeleteProductById(int id);
        public Task<ProductCreateDto> UpdateProduct(int id, ProductCreateDto ProductCreateDto);
    }
}
