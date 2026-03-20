using Pin.Products.Core.Services.Interfaces;
using Pin.Products.Core.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Pin.Products.Core.Services
{
    public class CategoryApiService : ICategoryApiService
    {
        private readonly HttpClient _httpClient;

        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.escuelajs.co/api/v1/");
        }

        public async Task<ResultModel<IEnumerable<CategoryModel>>> GetAllAsync()
        {
            var resultModel = new ResultModel<IEnumerable<CategoryModel>>();
            var result = await _httpClient.GetAsync($"{_httpClient.BaseAddress}categories");
            if(!result.IsSuccessStatusCode)
            {
                resultModel.Errors = new List<string> { "Connection error!" };
                return resultModel;
            }
            var content = await result.Content.ReadAsStringAsync();
            resultModel.Data = JsonSerializer.Deserialize<IEnumerable<CategoryModel>>(content);
            return resultModel;
        }
    }
}
