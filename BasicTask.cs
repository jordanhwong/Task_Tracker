using System.Text.Json;

namespace TaskManager
{

    public enum Status
    {
        ToDo,
        InProgress,
        Done
    }

    public class BasicTask
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Status CurrentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public BasicTask(int id, string description)
        {
            Id = id;
            Description = description;
            CurrentStatus = Status.ToDo;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public static void MarkStatus(int taskId, Status newStatus)
        {
            if (!File.Exists("tasks.json") || string.IsNullOrWhiteSpace(File.ReadAllText("tasks.json")))
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            List<BasicTask> tasks = JsonSerializer.Deserialize<List<BasicTask>>(File.ReadAllText("tasks.json"))!;
            int maxId = tasks.Max(t => t.Id);
            if (taskId < 1 || taskId > maxId)
            {
                Console.WriteLine($"Task ID {taskId} does not exist.");
                return;
            }

            tasks[taskId - 1].CurrentStatus = newStatus;
            tasks[taskId - 1].UpdatedAt = DateTime.Now;
            string updatedJson = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", updatedJson);
            return;
        }

        public static void AddTask(string description)
        {
            List<BasicTask> tasks;
            // Create json file if it doesn't exist
            if (!File.Exists("tasks.json"))
            {
                File.Create("tasks.json").Close();
            }

            string jsonString = File.ReadAllText("tasks.json");

            // Check if json is empty
            if (jsonString == "")
            {
                BasicTask initialTask = new BasicTask(1, description);
                tasks = new List<BasicTask> { initialTask };
                File.WriteAllText("tasks.json", JsonSerializer.Serialize(tasks));
                Console.WriteLine($"Task added successfully: (ID: 1)");
                return;
            }

            tasks = JsonSerializer.Deserialize<List<BasicTask>>(jsonString)!;

            //Find id value
            int id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;

            // Append new task to the json file
            BasicTask newTask = new BasicTask(id, description);
            tasks.Add(newTask);
            string updatedJson = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", updatedJson + Environment.NewLine);
            Console.WriteLine($"Task added successfully: (ID: {id})");
            return;
        }

        public static void ListTasks()
        {
            if (!File.Exists("tasks.json") || string.IsNullOrWhiteSpace(File.ReadAllText("tasks.json")))
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            List<BasicTask> tasks = JsonSerializer.Deserialize<List<BasicTask>>(File.ReadAllText("tasks.json"))!;
            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Description: {task.Description}, Status: {task.CurrentStatus}, Created At: {task.CreatedAt}, Updated At: {task.UpdatedAt}");
            }
            return;
        }

        public static void ListTasks(Status status)
        {
            if (!File.Exists("tasks.json") || string.IsNullOrWhiteSpace(File.ReadAllText("tasks.json")))
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            List<BasicTask> tasks = JsonSerializer.Deserialize<List<BasicTask>>(File.ReadAllText("tasks.json"))!;
            foreach (var task in tasks.Where(t => t.CurrentStatus == status))
            {
                Console.WriteLine($"ID: {task.Id}, Description: {task.Description}, Status: {task.CurrentStatus}, Created At: {task.CreatedAt}, Updated At: {task.UpdatedAt}");
            }
            return;
        }

        public static void UpdateTask(int taskId, string newDescription)
        {
            if (!File.Exists("tasks.json") || string.IsNullOrWhiteSpace(File.ReadAllText("tasks.json")))
            {
                Console.WriteLine("No tasks found.");
                return;
            }

            List<BasicTask> tasks = JsonSerializer.Deserialize<List<BasicTask>>(File.ReadAllText("tasks.json"))!;
            int maxId = tasks.Max(t => t.Id);
            if (taskId < 1 || taskId > maxId)
            {
                Console.WriteLine($"Task ID {taskId} does not exist.");
                return;
            }

            tasks[taskId - 1].Description = newDescription;
            tasks[taskId - 1].UpdatedAt = DateTime.Now;
            string updatedJson = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", updatedJson);
            return;
        }

        
    }

}

