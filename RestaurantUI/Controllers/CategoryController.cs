using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestaurantUI.Dtos.CategoryDtos;
using System.Text;

namespace RestaurantUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CategoryController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5291/api/Category");
            if (responseMessage.IsSuccessStatusCode) 
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values =JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateCategory() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto) 
        {
            createCategoryDto.Status = true;
            var client =_httpClientFactory.CreateClient();
            var jsondata =JsonConvert.SerializeObject(createCategoryDto);
            StringContent content = new StringContent(jsondata,Encoding.UTF8,"application/json");
            var responseMessage = await client.PostAsync("http://localhost:5291/api/Category", content);
            if (responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }
       
        public async Task<IActionResult> DeleteCategory(int id) 
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5291/api/Category/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        public async Task<IActionResult> UpdateCategory(int id) 
        {
            var client =_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5291/api/Category/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCategoryDto>(jsonData);
                return View(values);
                    
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var client =_httpClientFactory.CreateClient();
            var jsonData =JsonConvert.SerializeObject(updateCategoryDto);
            StringContent content = new StringContent(jsonData,Encoding.UTF8,"application/json");
            var responseMessage = await client.PutAsync("http://localhost:5291/api/Category/",content);
            if (responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }

}
