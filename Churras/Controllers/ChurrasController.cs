using AutoMapper;
using ChurrasApplication.ViewModel;
using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Churras.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChurrasController : ControllerBase
    {
        private IChurrasService _churrasService;
        private IMapper _mapper;

        public ChurrasController(IChurrasService churrasService, IMapper mapper)
        {
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

        [HttpGet("Id")]
        public async Task<ActionResult<bool>> Get(int Id)
        {
            try
            {
                var churrasco = await _churrasService.GetById(Id);
                var result = _mapper.Map<ChurrasViewModel>(await _churrasService.GetById(Id));
                result.Total = churrasco.ChurrasParticipante.Sum(x => x.Valor);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
        [HttpGet]
        public async Task<ActionResult<bool>> GetByFilter(Churrasco churras)
        {
            try
            {
                return Ok(await _churrasService.Find(x=>x.Data == churras.Data || x.Descricao.Contains(churras.Descricao)));
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }
    }
}
