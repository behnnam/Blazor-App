using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.repository
{
    public interface IUserRepository
    {
        Task<int> CreatUser(User Udto);
        Task<int> UpdateNews(User Udto);
        Task<int> ChangeStatus(int id,bool status);
        Task<User> GetUserById(int id);
        Task<List<User>> GetAllUsers();
       

    }
}
