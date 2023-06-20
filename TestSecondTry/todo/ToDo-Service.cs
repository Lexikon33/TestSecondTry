namespace TestSecondTry.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using TestSecondTry.Model;

    public class TodoService
    { 
        private List<todo> todos = new List<todo>();

        public List<todo> GetTodos()
        {
            return todos;
        }

        public void AddTodo(todo todo)
        {
            todo.Id = todos.Any() ? todos.Max(t => t.Id) + 1 : 1;
            todos.Add(todo);
        }

        public void ToggleTodoCompletion(int todoId)
        {
            var todo = todos.FirstOrDefault(t => t.Id == todoId);

            if (todo != null)
            {
                todo.IsCompleted = !todo.IsCompleted;
            }
        }

        public void RemoveTodo(int todoId)
        {
            var todo = todos.FirstOrDefault(t => t.Id == todoId);

            if (todo != null)
            {
                todos.Remove(todo);
            }
        }
    }
        
}
