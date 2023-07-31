using System.Data;

internal class UsersRepository : GenericRepository<ToDoTask>
{
    public UsersRepository(IDbConnection connection) : base(connection)
    {
    }
}
