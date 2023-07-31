using Dapper;
using System.Data;

internal class GenericRepository<T> : IGenericRepository<T> where T : class
{

    protected IDbConnection _connection;

    public GenericRepository(IDbConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<T> Execute(string sql, CommandType commandType = CommandType.StoredProcedure)
    {
        try
        {
            return _connection.Query<T>(sql, null, commandType: commandType); 
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException(); 
        }
    }

}
