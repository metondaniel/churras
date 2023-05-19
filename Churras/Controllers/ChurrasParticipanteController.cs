using AutoMapper;
using ChurrasApplication.ViewModel;
using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Service;
using ChurrasDomain.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace Churras.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChurrasParticipanteController : ControllerBase
    {
        private IChurrasParticipanteService _churrasParticipanteService;
        private IMapper _mapper;

        public ChurrasParticipanteController(IChurrasParticipanteService churrasParticipanteService, IMapper mapper)
        {
            _churrasParticipanteService = churrasParticipanteService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(ChurrasParticipanteViewModel churrasParticipanteViewModel)
        {
            try
            {
                await _churrasParticipanteService.Add(_mapper.Map<ChurrasParticipante>(churrasParticipanteViewModel));
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(int Id, ChurrasViewModel churrasParticipanteViewModel)
        {
            try
            {
                await _churrasParticipanteService.Update(Id, _mapper.Map<ChurrasParticipante>(churrasParticipanteViewModel));
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }
        }

        [HttpGet("Id")]
        public async Task<ActionResult<bool>> Get(int Id)
        {
            try
            {
                return Ok(await _churrasParticipanteService.GetById(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
        [HttpGet]
        public async Task<ActionResult<bool>> GetByFilter(ChurrasParticipante churras)
        {
            try
            {
                return Ok(await _churrasParticipanteService.Find(x => x.ChurrasId == churras.ChurrasId || x.ParticipanteId == churras.ParticipanteId));
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
    }
}
