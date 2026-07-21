using Application.Dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.repository
{
    public interface INewsRepository
    {
        Task<int> CreatNews(News Ndto);
        Task<int> UpdateNews(News Ndto);
        Task<int> ChangeStatus(int id, bool status);
        Task<News> GetNewsById(int id);
        Task<List<NewsDto>> GetAllNews();
    }
}
