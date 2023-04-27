using MVCBackend.Models;

namespace MVCBackend.Repositorio.IRepositorio
{
    public interface IUsuarioService
    {
        Task<List<Usuario>> ObtenerUsuarios();
    }
}
