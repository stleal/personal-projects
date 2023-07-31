using System.Data;
using Infrastructure.Repositories; 
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]/[action]")]
[ApiController]
public class ToDoTaskController : ControllerBase
{

    private WondersquadRepository _appRepository = new WondersquadRepository();

    [HttpGet]
    public string GetToDoTaskByTaskId(int id)
    {
        var result = _appRepository.GetToDoTaskByTaskId(id);
        return result.TaskId == 0 ? "No tasks found matching that TaskId." : GenerateToDoTaskResult(result); 
    }

    [HttpPost]
    public string GenerateToDoTaskResult(ToDoTask task)
    {
        string output = "ToDoTask:\n\n" + "TaskId: " + task.TaskId + "\nUserId: " + task.UserId;
        return output;
    }

}
