using miprimeraApi.Bussines.Contracts;
using miprimeraApi.Models;
using miprimeraApi.Services.Contracts;

namespace miprimeraApi.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _repository;
        public RolService(IRolRepository repository)
        {
            _repository = repository;
        }
        public Task<List<Rol>> GetList()
        {
            return _repository.GetList();
        }
        
    }

}
