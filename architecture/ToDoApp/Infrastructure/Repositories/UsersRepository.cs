using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

public class UsersRepository : IUsersRepository
{
    private readonly IConfiguration configuration;
    public UsersRepository(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    public async Task<int> AddAsync(Users entity)
    {
        entity.DateCreated = DateTime.Now;
        var sql = "INSERT INTO ToDoTasks (TaskName,Description,EstimatedCompletionDate,CompletionDate,CreatedDate,ModifiedDate,IsCompleted,Notes) VALUES " +
            "(@TaskName,@Description,@EstimatedCompletionDate,@CompletionDate,@CreatedDate,@ModifiedDate,@IsCompleted,@Notes)";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }
    }

    public async Task<int> DeleteAsync(int id)
    {
        var sql = "DELETE FROM Products WHERE Id = @Id";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, new { Id = id });
            return result;
        }
    }
    public async Task<IReadOnlyList<Users>> GetAllAsync()
    {
        var sql = "SELECT * FROM Products";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QueryAsync<Users>(sql);
            return result.ToList();
        }
    }
    public async Task<Users> GetByIdAsync(int id)
    {
        var sql = "SELECT * FROM Users WHERE Id = @Id";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.QuerySingleOrDefaultAsync<Users>(sql, new { Id = id });
            return result;
        }
    }
    public async Task<int> UpdateAsync(Users entity)
    {
        entity.ModifiedDate = DateTime.Now;
        var sql = "UPDATE ToDoTasks SET Name = @Name, Description = @Description, Barcode = @Barcode, Rate = @Rate, ModifiedOn = @ModifiedOn  WHERE Id = @Id";
        using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
        {
            connection.Open();
            var result = await connection.ExecuteAsync(sql, entity);
            return result;
        }
    }

}
