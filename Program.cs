﻿using System.Text.Json;
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
        Console.WriteLine("Commands: \n" +
                          "  add\t\t\tAdd a new task with the given description\n" +
                          "  mark-in-progress\tMark a task as in progress\n" +
                          "  mark-done\t\tMark a task as done\n" +
                          "  list\t\t\tList all tasks or filter by status (todo, in-progress, done)\n" +
                          "  update\t\tUpdate the description of a task\n" +
                          "  delete\t\tDelete a task");
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
        if (args.Length == 1)
        {
            BasicTask.ListTasks();
            return;
        }
        else
        {
            string filter = args[1].ToLower();
            if (filter == "todo")
            {
                BasicTask.ListTasks(Status.ToDo);
            }
            else if (filter == "in-progress")
            {
                BasicTask.ListTasks(Status.InProgress);
            }
            else if (filter == "done")
            {
                BasicTask.ListTasks(Status.Done);
            }
            else
            {
                Console.WriteLine("Invalid filter. Use 'todo', 'in-progress', or 'done'.");
                return;
            }
        }
        break;
    case "update":
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: update <task_id> <new_description>");
            return;
        }
        if (!int.TryParse(args[1], out taskId))
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }
        string newDescription = args[2];
        if (string.IsNullOrWhiteSpace(newDescription))
        {
            Console.WriteLine("New description cannot be empty.");
            return;
        }
        BasicTask.UpdateTask(taskId, newDescription);
        break;
    case "delete":
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: delete <task_id>");
            return;
        }
        if (!int.TryParse(args[1], out taskId))
        {
            Console.WriteLine("Invalid task ID.");
            return;
        }
        BasicTask.DeleteTask(taskId);
        break;
    default:
        Console.WriteLine("Unknown command. Use 'help' for a list of commands.");
        break;
}