using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimuladoMurex.Domain.Interfaces.Repositories;
using SimuladoMurex.Domain.Interfaces.Services;
using System;

namespace SimuladoMurex.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperationsController : ControllerBase
    {
        private readonly IOperationsService _operationsService;

        public OperationsController(IOperationsService operationsService)
        {
            _operationsService = operationsService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _operationsService.GetOperations();
            try
            {
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet("customers")]
        public IActionResult GetCustomers()
        {
            var result = _operationsService.Get();
            return Ok(result);
        }
    }
}
