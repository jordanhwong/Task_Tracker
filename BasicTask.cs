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

        public void MarkInProgress()
        {
            CurrentStatus = Status.InProgress;
        }

        public void MarkDone()
        {
            CurrentStatus = Status.Done;
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

            if (jsonString == "")
            {
                BasicTask initialTask = new BasicTask(1, description);
                tasks = new List<BasicTask> { initialTask };
                File.WriteAllText("tasks.json", JsonSerializer.Serialize(tasks));
                Console.WriteLine($"Task added successfully: (ID: 1)");
                return;
            }

            tasks = JsonSerializer.Deserialize<List<BasicTask>>(jsonString)!;

            int id = tasks.Count > 0 ? tasks.Max(t => t.Id) + 1 : 1;

            // Append new task to the json file
            BasicTask newTask = new BasicTask(id, description);
            tasks.Add(newTask);
            string updatedJson = JsonSerializer.Serialize(tasks);
            File.WriteAllText("tasks.json", updatedJson + Environment.NewLine);
            Console.WriteLine($"Task added successfully: (ID: {id})");
            return;
        }

    }

}

