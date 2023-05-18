using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasRepository
{
    public class ChurrasParticipanteRepository : RepositoryBase<ChurrasParticipante>, IChurrasParticipanteRepository
    {
        private readonly ChurrasDBContext _context;
        public ChurrasParticipanteRepository(ChurrasDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> Update(int Id, ChurrasParticipante churrasParticipate)
        {
            ChurrasParticipante churrasParticipanteEntity = await GetById(Id);
            churrasParticipanteEntity.Valor = churrasParticipate.Valor;
            churrasParticipanteEntity.Participante = churrasParticipate.Participante;

            _context.Set<ChurrasParticipante>().Update(churrasParticipanteEntity);
            _context.SaveChanges();
            return true;
        }
    }
}
