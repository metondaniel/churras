using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasRepository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ChurrasDBContext context) : base(context)
        {
        }
    }
}
