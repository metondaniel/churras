using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using ChurrasDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Service
{
    public class ParticipanteService : ServiceBase<Participante>, IParticipanteService
    {
        public IParticipanteRepository _repository;
        public ParticipanteService(IParticipanteRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<bool> Update(int ID, Participante churrasco)
        {
            return _repository.Update(ID, churrasco);
        }
    }
}
