namespace ToDoList 
{
   public class TaskManager
    {
        private readonly List<Task> _tasks;
        private int _nextId;

        public TaskManager()
        {
            _tasks = new List<Task>();
            _nextId = 1;
        }

        public void AddTask(string description)
        {
            var task = new Task(_nextId++, description);
            _tasks.Add(task);
            Console.WriteLine("Task added successfully.");
        }

        public void CompleteTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Task completed successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void DeleteTask(int taskId)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == taskId);
            if (task != null)
            {
                _tasks.Remove(task);
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void ListTasks()
        {
            foreach (var task in _tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
 
}