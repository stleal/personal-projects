using System.Data;

public interface IGenericRepository<T> where T : class
{

    // CRUD OPERATIONS 

    // CREATE 
    int InsertSql(string sql, object entity);
    int InsertUsingSP(string sql, object entity);

    // READ 
    IEnumerable<T> Execute(string sql, CommandType commandType);
    IEnumerable<T> ExecuteSql(string sql);
    IEnumerable<T> ExecuteStoredProcedure(string sql);

    // UPDATE 
    int Update(string sql); 

    // DELETE 


}