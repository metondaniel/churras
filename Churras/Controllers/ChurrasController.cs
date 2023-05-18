using AutoMapper;
using ChurrasApplication.ViewModel;
using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Churras.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChurrasController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private IChurrasService _churrasService;
        private Mapper _mapper;

        public ChurrasController(ILogger<UserController> logger, IChurrasService churrasService, Mapper mapper)
        {
            _logger = logger;
            _churrasService = churrasService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(ChurrasViewModel churrasViewModel)
        {
            try
            {
                await _churrasService.Add(_mapper.Map<Churrasco>(churrasViewModel));
                return Ok(true);
            }catch(Exception ex)
            {
                return BadRequest(false);
            }
            
        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(int Id,ChurrasViewModel churrasViewModel)
        {
            try
            {
                await _churrasService.Update(Id,_mapper.Map<Churrasco>(churrasViewModel));
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
    }
}
