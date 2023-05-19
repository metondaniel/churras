using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasRepository
{
    public class ParticipanteRepository : RepositoryBase<Participante>, IParticipanteRepository
    {
        public ParticipanteRepository(ChurrasDBContext context) : base(context)
        {
        }

        public async Task<bool> Update(int Id, Participante participante)
        {
            Participante participanteEntity = await GetById(Id);
            participanteEntity.Nome = participante.Nome;

            _context.Set<Participante>().Update(participanteEntity);
            _context.SaveChanges();
            return true;
        }
    }
}
