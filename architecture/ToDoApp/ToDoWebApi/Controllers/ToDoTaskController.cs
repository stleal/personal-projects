using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]/[action]")]
[ApiController]
public class ToDoTaskController : ControllerBase
{
    private readonly IToDoTaskRepository repository;
    public ToDoTaskController(IToDoTaskRepository repository)
    {
        this.repository = repository;
    }    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var data = await repository.GetAllAsync();
        return Ok(data);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var data = await repository.GetByIdAsync(id);
        if (data == null) return Ok();
        return Ok(data);
    }
    [HttpPost]
    public async Task<IActionResult> Add(ToDoTask task)
    {
        var data = await repository.AddAsync(task);
        return Ok(data);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var data = await repository.DeleteAsync(id);
        return Ok(data);
    }
    [HttpPut]
    public async Task<IActionResult> Update(ToDoTask task)
    {
        var data = await repository.UpdateAsync(task);
        return Ok(data);
    }
    [HttpPut]
    public async Task<IActionResult> UpdateCompletionDate(int taskId, DateTime completionDate)
    {
        var data = await repository.UpdateCompletionDateAsync(taskId, completionDate);
        return Ok(data);
    }
}