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

    public IEnumerable<T> ExecuteSql(string sql)
    {
        try
        {
            return _connection.Query<T>(sql, null, commandType: CommandType.Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException();
        }
    }

    public IEnumerable<T> ExecuteStoredProcedure(string sql)
    {
        try
        {
            return _connection.Query<T>(sql, null, commandType: CommandType.StoredProcedure);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException();
        }
    }

    // Insert by SQL 
    public int InsertSql(string sql, object entity)
    {
        try
        {
            return _connection.Execute(sql, entity, commandType: CommandType.Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException();
        }
    }

    // Insert using SP
    public int InsertUsingSP(string sql, object entity)
    {
        try
        {
            return _connection.Execute(sql, entity, commandType: CommandType.StoredProcedure);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException();
        }
    }

    // Update using SQL 
    public int Update(string sql)
    {
        try
        {
            return _connection.Execute(sql, commandType: CommandType.Text); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException(); 
        }
    }

    // Delete SQL 
    public int Delete(string sql)
    {
        try
        {
            return _connection.Execute(sql, null, commandType: CommandType.Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw new NotImplementedException();
        }
    }

}
