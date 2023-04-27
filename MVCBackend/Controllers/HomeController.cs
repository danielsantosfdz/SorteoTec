using Microsoft.AspNetCore.Mvc;
using MVCBackend.Models;
using MVCBackend.Repositorio.IRepositorio;
using System.Diagnostics;
using System.Net.Http;

namespace MVCBackend.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;


        public HomeController() {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"); 
        
        }

        [HttpPost]
        public async Task<IActionResult>  ObtenerDatos(Usuario usuario)
        {

            if (!ModelState.IsValid)
            {
                return View("Index", usuario);
            }

        
            HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/users"); 
            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                
                return Ok(responseContent);
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }



        }


        public async Task<IActionResult> Index()
        {
            var model = new Usuario();
            return View(model);
        }

        
    }
}