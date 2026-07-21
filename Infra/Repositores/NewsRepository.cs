using Application.Dto;
using Application.Interfaces.repository;
using Dapper;
using Domain.Entities;
using Infra.persistent;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Infra.Repositores
{
    public class NewsRepository : INewsRepository
    {
        private readonly DapperContext _dapperContext;
        public NewsRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public NewsRepository() { }
        public async Task<int> ChangeStatus(int id, bool status)
        {
            var sql = "Update  [News] set id=@id  where id=@id";
            var connection = _dapperContext.CreateConnection();
            var res = await connection.ExecuteAsync(sql, new { id = id });
            return res;

        }

        public async Task<int> CreatNews(global::Domain.Entities.News Ndto)
        {
            var sql = "insert into [News] (Title,Description,UserId) values(@Title,@Description,@UserId)";
            var connection=_dapperContext.CreateConnection();
            var res=await connection.ExecuteAsync(sql,  Ndto );
            return res;
        }

        public async Task<List<NewsDto>> GetAllNews()
        {
            var sql = "select Ne.Id,Ne.Title,Ne.Description,Ne.UserId ,Ur.FullName from [News] as Ne inner join [User]  as Ur  on Ne.UserId=Ur.Id ";
            var connections = _dapperContext.CreateConnection();
            var res = await connections.QueryAsync<NewsDto>(sql);
            return res.ToList();
        }

        public async Task<global::Domain.Entities.News> GetNewsById(int id)
        {
            var sql = "select Id,Title,Description,UserId from [News] where id=@id";
            var connections = _dapperContext.CreateConnection();
            var res=await connections.QueryFirstOrDefaultAsync<News>(sql ,new { id=id});
            return res;
        }

        public async Task<int> UpdateNews(global::Domain.Entities.News Ndto)
        {
            var sql = "Update  [News] set  Title=@Title,Description=@Description where Id=@Id";
            var connection = _dapperContext.CreateConnection();
            var res = await connection.ExecuteAsync(sql, Ndto );
            return res;
        }
    }
}
