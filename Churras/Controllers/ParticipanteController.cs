using AutoMapper;
using ChurrasApplication.ViewModel;
using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace Churras.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private IParticipanteService _participanteService;
        private IMapper _mapper;

        public ParticipanteController( IParticipanteService participanteService, IMapper mapper)
        {
            _participanteService = participanteService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(ParticipanteViewModel churrasParticipanteViewModel)
        {
            try
            {
                await _participanteService.Add(_mapper.Map<Participante>(churrasParticipanteViewModel));
                return Ok(true);
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(int Id, ParticipanteViewModel churrasParticipanteViewModel)
        {
            try
            {
                await _participanteService.Update(Id, _mapper.Map<Participante>(churrasParticipanteViewModel));
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
                return Ok(await _participanteService.GetById(Id));
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
        [HttpGet]
        public async Task<ActionResult<bool>> GetByFilter(ParticipanteViewModel churras)
        {
            try
            {
                return Ok(await _participanteService.Find(x => x.Nome == churras.Nome));
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
    }
}
