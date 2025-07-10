using miprimeraApi.Models;

namespace miprimeraApi.Services.Contracts
{
    public interface IRolService
    {
        Task<List<Rol>> GetList();
    }
}
