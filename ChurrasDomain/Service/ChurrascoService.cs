using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using ChurrasDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Service
{
    public class ChurrascoService : ServiceBase<Churrasco>, IChurrasService
    {
        public IChurrasRepository _repository;
        public ChurrascoService(IChurrasRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<bool> Update(int ID, Churrasco churrasco)
        {
            return _repository.Update(ID,churrasco);
        }

    }
}
