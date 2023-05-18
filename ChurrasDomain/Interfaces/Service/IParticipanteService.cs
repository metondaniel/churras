using ChurrasDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Interfaces.Service
{
    public interface IParticipanteService : IServiceBase<Participante>
    {
        Task<bool> Update(int Id, Participante participante);
    }
}
