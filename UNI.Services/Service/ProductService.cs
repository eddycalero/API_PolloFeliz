
using AutoMapper;
using UNI.Models;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class ProductServices: IProductService
    {
        private readonly IUnitofWork _uni;
        private readonly IMapper _mapper;
        public ProductServices( IUnitofWork unitof, IMapper mapper)
        { 
          _uni = unitof;
          _mapper = mapper;
        }


        public async Task<ProductCreateDto> CreateProductDto(ProductCreateDto ProductCreateDto)
        {
   
            _uni.BeginTransaction();
            try
            {
                Product Product = _mapper.Map<Product>(ProductCreateDto);
                ProductCreateDto.ProductId = await _uni.ProductRepository.CreateAsync(Product);
                _uni.Commit();
            }
            catch (Exception ex)
            {
                _uni.Rollback();
            }
            return ProductCreateDto;
        }

        public async Task<bool> DeleteProductById(int id)
        {
            try
            {
                Product Product = await _uni.ProductRepository.GetByIdAsync(id);

                if (Product is null)
                {
                    return false;
                }
                await _uni.ProductRepository.DeleteAsync(Product);
            }
            catch (Exception ex) 
            {
            }
            return true;
        }

        public async Task<dynamic> GetAllProduct()
        {
            try
            {
                string query = "select * from product_list()";
                dynamic? result = await _uni!.SubCategoryRepository!.QueryFirst(query);
                return result;
            }
            catch (Exception ex)
            {
            }

            return null;
        }

        public Task<ProductCreateDto> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductCreateDto> UpdateProduct(int id, ProductCreateDto ProductCreateDto)
        { 
            _uni.BeginTransaction();
            try
            {
                Product Product = await _uni.ProductRepository.GetByIdAsync(id);
                _mapper.Map(ProductCreateDto, Product);

                await _uni.ProductRepository.UpdateAsync(Product);

                _uni.Commit();
            }
            catch (Exception ex) 
            {
                 _uni.Rollback();
            }
            return ProductCreateDto;   
        }
    }
}
