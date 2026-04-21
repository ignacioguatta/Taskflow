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

            // Resolución: combinamos ambas versiones
            taskService.CrearTarea();
            taskService.ListarTareas();
            taskService.ListarTareasPorEstado(TaskStatus.Pendiente);
            taskService.UpdateStatus(1, TaskStatus.EnProgreso);
        }
    }
}