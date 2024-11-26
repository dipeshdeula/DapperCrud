using Dapper;
using DapperCrud.DapperContext;
using DapperCrud.Interface;
using DapperCrud.Models;
using System.Data;

namespace DapperCrud.Repository
{
    public class DapperRepo : IDapperService
    {
        private readonly DapperDbContext _dapperDbContext;
        public DapperRepo(DapperDbContext dapperDbContext)
        {
            _dapperDbContext = dapperDbContext;
        }

        public async Task<string> CreateTask(ToDo toDo)
        {
            string response = string.Empty;
            var sql = "Insert into Todo(Id,Name,Description,Status) values (@Id,@Name,@Description,@Status)";
            var parameters = new DynamicParameters();
            parameters.Add("Id", toDo.Id, DbType.String);
            parameters.Add("Name", toDo.Name, DbType.String);
            parameters.Add("Description", toDo.Description, DbType.String);
            parameters.Add("Status", toDo.Status, DbType.String);

            using (var connection = _dapperDbContext.CreateConnection())
            {
                await connection.ExecuteAsync(sql, parameters);
                response = "pass";
            }
            return response;
            
        }

        public async Task<string> DeleteTask(int id)
        {
            string response = string.Empty;
            var sql = "Delete from ToDo where id=@id";
            using (var connection = _dapperDbContext.CreateConnection())
            {
                await connection.ExecuteAsync(sql, new { id });
                response = "Pass";
            }
            return response;
            
        }

        public async Task<List<ToDo>> GetAll()
        {
            var sql = "SELECT * FROM ToDo";
            using (var connection = _dapperDbContext.CreateConnection())
            { 
                var tasks = await connection.QueryAsync<ToDo>(sql);
                return tasks.ToList();
            }
        }

        public async Task<ToDo> GetTaskById(int id)
        {
           var sql = "SELECT * FROM ToDo WHERE Id = @Id";
            using (var connection = _dapperDbContext.CreateConnection())
            {
                var task = await connection.QueryFirstOrDefaultAsync<ToDo>(sql, new {  id });
                return task;
            }
        }

        public async Task<string> UpdateTask(ToDo toDo)
        {
            string response = string.Empty;
            var sql = "Update ToDo set Id = @Id, Name=@Name, Description = @Description, Status = @Status";
            var parameters = new DynamicParameters();
            parameters.Add("Id", toDo.Id, DbType.String);
            parameters.Add("Name", toDo.Name, DbType.String);
            parameters.Add("Description", toDo.Description, DbType.String);
            parameters.Add("Status", toDo.Status, DbType.String);

            using (var connection = _dapperDbContext.CreateConnection())
            {
                await connection.ExecuteAsync(sql, parameters);
                response = "pass";
            }
            return response;

        }
    }
}
