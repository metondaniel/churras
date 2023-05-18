using ChurrasDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Interfaces.Repository
{
    public interface IChurrasParticipanteRepository : IRepositoryBase<ChurrasParticipante>
    {
        Task<bool> Update(int Id, ChurrasParticipante participante);
    }
}
