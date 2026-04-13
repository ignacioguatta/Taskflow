using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Models
{
    internal class TaskItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Responsible { get; set; }
        public enum Status { NotStarted, InProgress, Completed }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
