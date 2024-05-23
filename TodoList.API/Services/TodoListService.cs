public interface ITodoListService
{
  public TodoModel[] GetAllTodos();
  public TodoModel CreateNewTodo(CreateTodoModel todoInput);

  public TodoModel UpdateTodo(int todoId, UpdateTodoModel todoInput);
}

public class TodoListInMemoryService : ITodoListService
{
  private List<TodoModel> todos;
  private int nextId;

  public TodoListInMemoryService()
  {
    todos = new List<TodoModel>();
    nextId = 0;
  }

  public TodoModel[] GetAllTodos()
  {
    return todos.ToArray();
  }

  public TodoModel CreateNewTodo(CreateTodoModel todoInput)
  {
    TodoModel newTodo = new TodoModel()
    {
      Id = nextId++,
      Title = todoInput.Title,
      CreatedAt = DateTime.Now,
      UpdatedAt = DateTime.Now,
    };

    todos.Add(newTodo);

    return newTodo;
  }

  public TodoModel UpdateTodo(int todoId, UpdateTodoModel todoInput)
  {
    // Naturual Language Syntaxt
    // var foundTodo = from todo in todos where todo.Id == todoId select todo;

    // Fluent syntaxt
    // var foundTodo = todos.First((todo) => { return todo.Id == todoId; });
    var foundTodo = todos.First(todo => todo.Id == todoId);

    // there might be none todo elements
    if (foundTodo == null)
    {
      // Throw == return, but special
      throw new ArgumentException("Todo Not found");
    }

    foundTodo.IsComplete = todoInput.IsComplete;
    foundTodo.UpdatedAt = DateTime.Now;

    return foundTodo;
  }
}
