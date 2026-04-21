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

            // Crear tareas
            taskService.CrearTarea();

            // Listar todas las tareas
            taskService.ListarTareas();

            // Cambiar estado de la tarea 1
            Console.WriteLine("\n-- Cambiando estado de la tarea 1 a EnProgreso --");
            bool resultado = taskService.UpdateStatus(1, TaskStatus.EnProgreso);

            if (resultado)
                Console.WriteLine("Estado actualizado correctamente.");
            else
                Console.WriteLine("No se encontró la tarea.");

            // Listar solo las tareas en progreso
            taskService.ListarTareasPorEstado(TaskStatus.EnProgreso);
        }
    }
}