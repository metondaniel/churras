using ChurrasDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Interfaces.Repository
{
    public interface IParticipanteRepository : IRepositoryBase<Participante>
    {
        Task<bool> Update(int Id, Participante participante);
    }
}
