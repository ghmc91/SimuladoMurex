using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimuladoMurex.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimuladoMurex.WebApi.Controllers
{
    [Route("api/[Controller]")]
    public class MoController : Controller
    {
        private readonly IMoRepository _moRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public MoController(IMoRepository moRepository, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment)
        {
            _moRepository = moRepository;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(_moRepository.GetAll());
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
