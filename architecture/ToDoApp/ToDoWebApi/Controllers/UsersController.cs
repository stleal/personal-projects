using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]/[action]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUsersRepository repository;
    public UsersController(IUsersRepository repository)
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
    public async Task<IActionResult> Add(Users user)
    {
        var data = await repository.AddAsync(user);
        return Ok(data);
    }
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var data = await repository.DeleteAsync(id);
        return Ok(data);
    }
    [HttpPut]
    public async Task<IActionResult> Update(Users user)
    {
        var data = await repository.UpdateAsync(user);
        return Ok(data);
    }
}