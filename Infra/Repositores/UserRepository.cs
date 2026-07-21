using Application.Interfaces.repository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositores
{
    public class UserRepository : IUserRepository
    {
        public Task<int> ChangeStatus(int id, bool status)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreatUser(User Udto)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateNews(User Udto)
        {
            throw new NotImplementedException();
        }
    }
}
