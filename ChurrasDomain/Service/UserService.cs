using ChurrasDomain.Domain;
using ChurrasDomain.Interfaces.Repository;
using ChurrasDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChurrasDomain.Service
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
