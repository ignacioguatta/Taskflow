using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Models
{
    public enum TaskStatus  // ✅ Enum definido FUERA de la clase, mismo namespace
    {
        Pendiente,
        EnProgreso,
        Completada
    }
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Responsible { get; set; }
        public TaskStatus Status { get; set; } // ✅ Propiedad que usa el enum
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
