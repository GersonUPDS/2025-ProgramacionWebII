using miprimeraApi.Models;

namespace miprimeraApi.Bussines.Contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
    }
}
