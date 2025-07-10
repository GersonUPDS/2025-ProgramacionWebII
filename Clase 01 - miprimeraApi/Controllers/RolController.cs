using Microsoft.AspNetCore.Mvc;
using miprimeraApi.Models;
using miprimeraApi.Services.Contracts;
using System.Runtime.CompilerServices;

namespace miprimeraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RolController
    {
        private readonly IRolService rolService;
        public RolController(IRolService rolService)
        {
            this.rolService = rolService;
        }
        [HttpGet]

        public async Task<List<Rol>> GetList()
        {
            return await this.rolService.GetList();
        }
    }
}
