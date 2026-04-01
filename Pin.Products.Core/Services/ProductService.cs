using Pin.Products.Core.Services.Interfaces;
using Pin.Products.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.Products.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.escuelajs.co/api/v1/products");
        }

        public Task<ResultModel<ProductModel>> CreateAsync(CreateOrUpdateProductModel newProduct)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<IEnumerable<ProductModel>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<ProductModel>> UpdateAsync(CreateOrUpdateProductModel newProduct)
        {
            throw new NotImplementedException();
        }
    }
}
