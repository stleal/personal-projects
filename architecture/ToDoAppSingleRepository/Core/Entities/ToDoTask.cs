public class ToDoTask
{
    public int TaskId { get; set; }
    public int UserId { get; set; }
    public int CharacterId { get; set; }
    public string CharacterName { get; set; }
    public string TaskName { get; set; }
    public string Description { get; set; }
    public DateTime EstimatedCompletionDate { get; set; }
    public DateTime CompletionDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool IsCompleted { get; set; }
    public string Notes { get; set; }
}