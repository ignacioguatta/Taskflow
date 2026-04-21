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

            // Versión A: primero creamos y luego listamos por estado
            taskService.CrearTarea();
            taskService.ListarTareasPorEstado(TaskStatus.Pendiente);
        }
    }
}