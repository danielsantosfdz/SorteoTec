using MVCBackend.Models;
using MVCBackend.Repositorio.IRepositorio;
using System.Text.Json;

namespace MVCBackend.Repositorio
{
    public class UsuarioService: IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Usuario>> ObtenerUsuarios()
        {
            var response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");
            response.EnsureSuccessStatusCode();
            var responseStream = await response.Content.ReadAsStreamAsync();
            var usuarios = await JsonSerializer.DeserializeAsync<List<Usuario>>(responseStream);
            return usuarios;
        }
    }
}
