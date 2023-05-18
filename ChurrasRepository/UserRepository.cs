using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasRepository
{
    internal class UserRepository : RepositoryBase<User>
    {
        public UserRepository(ChurrasDBContext context) : base(context)
        {
        }
    }
}
