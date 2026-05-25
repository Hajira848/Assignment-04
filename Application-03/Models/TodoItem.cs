using Microsoft.AspNetCore.Components.Web;

namespace Application_03.Models
{
    // Task parameters definition blueprint
    public class TodoItem
    {
        public string Title { get; set; } = string.Empty;
        public bool IsEditing { get; set; } = false;
        public string EditText { get; set; } = string.Empty;
    }

    // App core mechanics logic layer execution container
    public class TodoAppEngine
    {
        // Two-way bound parameters
        public string NewTaskTitle { get; set; } = string.Empty;
        public List<TodoItem> TasksList { get; set; } = new List<TodoItem>();

        // Logic implementation to insert data rows into the array list collection
        public void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskTitle))
            {
                TasksList.Add(new TodoItem
                {
                    Title = NewTaskTitle.Trim()
                });
                NewTaskTitle = string.Empty; // Resets input text back to empty state
            }
        }

        // Handles triggering submission automatically if user hits 'Enter' key
        public void HandleKeyPress(KeyboardEventArgs e)
        {
            if (e.Key == "Enter")
            {
                AddTask();
            }
        }

        // Activates inline edit interface fields
        public void StartEdit(TodoItem task)
        {
            task.EditText = task.Title;
            task.IsEditing = true;
        }

        // Confirms variations updates and flushes temporary storage keys
        public void SaveEdit(TodoItem task)
        {
            if (!string.IsNullOrWhiteSpace(task.EditText))
            {
                task.Title = task.EditText.Trim();
                task.IsEditing = false;
            }
        }

        // Discards modifications and closes the inline viewport
        public void CancelEdit(TodoItem task)
        {
            task.IsEditing = false;
        }

        // Removes individual targeting row data instances
        public void DeleteTask(TodoItem task)
        {
            TasksList.Remove(task);
        }

        // Logic mapping to completely clear out the tasks collection list state
        public void ClearAllTasks()
        {
            TasksList.Clear();
        }
    }
}