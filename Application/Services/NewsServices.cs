using Application.Dto;
using Application.Interfaces.repository;
using Application.Interfaces.service;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class NewsServices : INewsServices
    {
        private readonly INewsRepository _newsRepository;
        public NewsServices(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;

        }
        public async Task<int> ChangeStatus(int id, bool status)
        {
            var res = await _newsRepository.ChangeStatus(id, status);
            return res;
        }

        public async Task<int> CreatNews(NewsDto Ndto)
        {
            var newsinput = new News
            {
                Description = Ndto.Description,
                Title = Ndto.Title,
                UserId = Ndto.UserId,

            };
            var res = await _newsRepository.CreatNews(newsinput);
            return res;
        }

        public async Task<List<NewsDto>> GetAllNews()
        {
            var res = await _newsRepository.GetAllNews();
            var newsout = new List<NewsDto>();
            if (res is null)
            {
                return newsout;

            }
            return res.Select(x => new NewsDto {Id=x.Id, Title = x.Title, Description = x.Description, UserId = x.UserId,FullName=x.FullName }).ToList();
        }

        public async Task<NewsDto> GetNewsById(int id)
        {
            var res = await _newsRepository.GetNewsById(id);
            var newsout = new NewsDto();
            if (res is null)
            {
                return newsout;

            }
            return new NewsDto { Id = res.Id, Title = res.Title, Description = res.Description };

        }

        public async Task<int> UpdateNews(NewsDto Ndto)
        {
            var newsinput = new News
            {
                Id= Ndto.Id,
                
                Description = Ndto.Description,
                Title = Ndto.Title,
                UserId = Ndto.UserId,

            };
            var res = await _newsRepository.UpdateNews(newsinput);
            return res;
        }
    }
}

