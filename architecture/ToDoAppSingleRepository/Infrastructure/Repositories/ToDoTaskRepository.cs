using System.Data;

internal class ToDoTaskRepository : GenericRepository<ToDoTask>
{
    public ToDoTaskRepository(IDbConnection connection) : base(connection)
    {
    }
}
