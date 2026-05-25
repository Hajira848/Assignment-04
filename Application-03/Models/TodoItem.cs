using Microsoft.AspNetCore.Components.Web;

namespace Application_03.Models
{
    public class TodoItem
    {
        public string Title { get; set; } = string.Empty;
        public bool IsEditing { get; set; } = false;
        public string EditText { get; set; } = string.Empty;
    }
    public class TodoAppEngine
    {
        public string NewTaskTitle { get; set; } = string.Empty;
        public List<TodoItem> TasksList { get; set; } = new List<TodoItem>();
        public void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskTitle))
            {
                TasksList.Add(new TodoItem
                {
                    Title = NewTaskTitle.Trim()
                });
                NewTaskTitle = string.Empty; 
            }
        }
        public void HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                AddTask();
            }
        }
        public void StartEdit(TodoItem task)
        {
            task.EditText = task.Title;
            task.IsEditing = true;
        }
        public void SaveEdit(TodoItem task)
        {
            if (!string.IsNullOrWhiteSpace(task.EditText))
            {
                task.Title = task.EditText.Trim();
                task.IsEditing = false;
            }
        }
        public void CancelEdit(TodoItem task)
        {
            task.IsEditing = false;
        }
        public void DeleteTask(TodoItem task)
        {
            TasksList.Remove(task);
        }
        public void ClearAllTasks()
        {
            TasksList.Clear();
        }
    }
}

