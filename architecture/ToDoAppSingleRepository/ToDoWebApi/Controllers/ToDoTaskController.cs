using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

[Route("api/[controller]/[action]")]
[ApiController]
public class ToDoTaskController : ControllerBase
{

    private WondersquadRepository _appRepository = new WondersquadRepository();

    [HttpPost]
    public string InsertToDoTask(ToDoTask entity)
    {
        var result = _appRepository.InsertToDoTask(entity);
        return result > 0 ? "Succesfully inserted a record into the database. " : "Failed to INSERT into the database.";
    }

    [HttpPost]
    public string InsertToDoTaskUsingStoredProcedure(ToDoTask entity)
    {
        var result = _appRepository.InsertToDoTaskUsingStoredProcedure(entity);
        return result > 0 ? "Succesfully inserted a record into the database. " : "Failed to INSERT into the database.";
    }

    [HttpGet]
    public string GetToDoTaskByTaskId(int taskId)
    {
        var result = _appRepository.GetToDoTaskByTaskId(taskId);
        return result.TaskId == 0 ? "No tasks found matching that TaskId." : JsonConvert.SerializeObject(result);
    }

    [HttpPut]
    public string UpdateToDoTaskByTaskId(DateTime completionDate, int taskId, string completionNotes)
    {
        var result = _appRepository.UpdateToDoTaskByTaskId(completionDate, taskId, completionNotes);
        return result > 0 ? "Succesfully updated a record in the database. " : "Failed to UPDATE the database.";
    }

    [HttpDelete]
    public string DeleteToDoTaskByTaskId(int taskId)
    {
        var result = _appRepository.DeleteToDoTaskByTaskId(taskId);
        return result > 0 ? "Succesfully deleted a record from the database. " : "Failed to DELETE from the database.";
    }

}
