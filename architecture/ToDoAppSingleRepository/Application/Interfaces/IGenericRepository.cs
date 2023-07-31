using System.Data;

public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> Execute(string sql, CommandType commandType);
}