using System;
using TaskFlow.Services;
using TaskFlow.Models;
using TaskStatus = TaskFlow.Models.TaskStatus;

namespace TaskFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService taskService = new TaskService();

            // Versión B: primero creamos y luego listamos todas
            taskService.CrearTarea();
            taskService.ListarTareas();
            taskService.UpdateStatus(1, TaskStatus.EnProgreso);
        }
    }
}