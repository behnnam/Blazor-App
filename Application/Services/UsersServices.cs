using Application.Dto;
using Application.Interfaces.service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class UsersServices : IUsersServices
    {
        public Task<int> ChangeStatus(int id, bool status)
        {
            throw new NotImplementedException();
        }

        public Task<int> CreatUser(UserDto Udto)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserDto>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserDto> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateUser(UserDto Udto)
        {
            throw new NotImplementedException();
        }
    }
}
