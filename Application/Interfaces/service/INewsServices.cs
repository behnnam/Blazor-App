using Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.service
{
    public interface INewsServices
    {
        Task<int> CreatNews(NewsDto Ndto);
        Task<int> UpdateNews(NewsDto Ndto);
        Task<int> ChangeStatus(int id, bool status);
        Task<NewsDto> GetNewsById(int id);
        Task<List<NewsDto>> GetAllNews();
    }
}
