using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ChurrasDomain.Interfaces.Service
{
    public interface IChurrasService : IServiceBase<Churrasco>
    {
        Task<bool> Update(int ID, Churrasco churrasco); 
    }
}
