using System.Text.Json;
using TaskManager;

if (args.Length <= 0)
{
    Console.WriteLine("Improper usage. Please provide a command or use 'help' for usage.");
    return;
}

string command = args[0].ToLower();
switch (command)
{
    case "help":
        Console.WriteLine("Usage: run <command> [options]");
        break;
    
    case "add":
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: add <description>");
            return;
        }
        string description = args[1];
        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("Description cannot be empty.");
            return;
        }
        BasicTask.AddTask(description);
        break;
    case "mark-in-progress":
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: mark-in-progress <task_id>");
            return;
        }
        if (!int.TryParse(args[1], out int taskId))
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }
        BasicTask.MarkStatus(taskId, Status.InProgress);
        break;
    case "mark-done":
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: mark-done <task_id>");
            return;
        }
        if (!int.TryParse(args[1], out taskId))
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }
        BasicTask.MarkStatus(taskId, Status.Done);
        break;
    case "list":
        // List logic here
        break;
    case "update":
        // Update logic here
        break;
    case "delete":
        // Delete logic here
        break;
    default:
        Console.WriteLine("Unknown command. Use 'help' for a list of commands.");
        break;
}