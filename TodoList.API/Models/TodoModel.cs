class TodoModel
{
  public int Id { get; set; }
  public required string Title { get; set; }
  public bool IsComplete { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime UpdatedAt { get; set; }
}
