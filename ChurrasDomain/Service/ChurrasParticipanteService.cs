using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using ChurrasDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Service
{
    public class ChurrasParticipanteService : ServiceBase<ChurrasParticipante>, IChurrasParticipanteService
    {
        public IChurrasParticipanteRepository _repository;
        public ChurrasParticipanteService(IChurrasParticipanteRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<bool> Update(int ID, ChurrasParticipante churrasco)
        {
            return _repository.Update(ID, churrasco);
        }
    }
}
