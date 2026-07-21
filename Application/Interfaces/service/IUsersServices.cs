using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.service
{
    public interface IUsersServices
    {
        Task<int> CreatUser(UserDto Udto);
        Task<int> UpdateUser(UserDto Udto);
        Task<int> ChangeStatus(int id, bool status);
        Task<UserDto> GetUserById(int id);
        Task<List<UserDto>> GetAllUsers();
    }
}
