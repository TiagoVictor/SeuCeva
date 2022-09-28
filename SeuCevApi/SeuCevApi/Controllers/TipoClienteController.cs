using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeuCevApi.Service.Interface;

namespace SeuCevApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoClienteController : ControllerBase
    {
        private readonly ITipoClienteService _service;

        public TipoClienteController(ITipoClienteService tipoClienteService)
        {
            _service = tipoClienteService;
        }

    }
}
