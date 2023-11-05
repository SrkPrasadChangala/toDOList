# ToDoList Application

This is a simple console application of task management system that allows users to manage their to-do items. It provides basic functionality to add, complete, and delete tasks.

## Structure

The application is composed of three main C# files:

- `Program.cs`: Contains the Main method and the user interface logic.
- `Task.cs`: Represents the model of a Task with properties for task description, ID, and completion status.
- `TaskManager.cs`: Contains the logic to manage tasks, including adding, completing, and deleting tasks, as well as listing all current tasks.

## Getting Started

To run this application, you'll need to have [.NET SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Prerequisites

- .NET 5.0 SDK or later

### Running the Application

Navigate to the project's root directory in the command line, and use the following .NET CLI command:

```bash
dotnet run

Usage
Once the application is running, it operates in a command-line interface. Follow the on-screen prompts to interact with the task manager.

Development
If you wish to contribute or modify the application, you can open the project in Visual Studio Code or your preferred IDE that supports C# development.

Files and Responsibilities
Program.cs: The entry point of the application. Handles the command-line user interface.
Task.cs: Defines the Task class with properties such as Id, Description, and IsCompleted.
TaskManager.cs: Manages a list of tasks and provides methods to manipulate them.
Building the Application
To build the application, run the following command:

bash
Copy code
dotnet build
This command compiles the application and checks for errors. Fix any build errors before proceeding.

Testing
Currently, there are no automated tests for this application. Testing is done manually by executing the application and verifying the behavior of the task management features.

Contributing
Contributions are welcome. Please feel free to fork the repository and submit pull requests.

License
This project is open-source.



