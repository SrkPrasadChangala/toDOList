using System.Xml.Serialization;

using ToDoList;
class Program
{
    static void Main(string[] args)
    {
        var taskManager = new TaskManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Complete Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. List Tasks");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.Write("Enter task description: ");
                    var description = Console.ReadLine();
                    taskManager.AddTask(description);
                    break;
                case "2":
                    Console.Write("Enter task ID to complete: ");
                    var completeId = int.Parse(Console.ReadLine());
                    taskManager.CompleteTask(completeId);
                    break;
                case "3":
                    Console.Write("Enter task ID to delete: ");
                    var deleteId = int.Parse(Console.ReadLine());
                    taskManager.DeleteTask(deleteId);
                    break;
                case "4":
                    taskManager.ListTasks();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine(); // Add a blank line for better readability
        }
    }

}
