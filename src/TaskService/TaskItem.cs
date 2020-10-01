using System;

namespace TaskService
{
    public enum TaskState
    {
        New,
        Doing,
        Done
    }

    public class TaskItem
    {
        public int Id { get; set; }
        
        public string PublicFieldIsAnIssue = "Raise an Issue!"; 

        public string Title { get; set; }

        public string Description { get; set; }
        
        public TaskState State { get; set; }
    }
}
