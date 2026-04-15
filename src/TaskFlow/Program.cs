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
            taskService.CrearTarea();

            Console.WriteLine("\n-- Tareas actuales --");
            foreach (var t in taskService.GetAllTasks())
            {
                Console.WriteLine($"ID: {t.Id} | Titulo: {t.Title} | Estado: {t.Status}");
            }

            Console.WriteLine("\n-- Cambiando estado de la tarea 1 a enProgreso --");
            bool resultado = taskService.UpdateStatus(1, TaskStatus.EnProgreso);

            if (resultado)
                Console.WriteLine("Estado actualizado correctamente!");
            else
                Console.WriteLine("No se encontró la tarea.");
            
            Console.WriteLine("\n-- Estado Final --");
            foreach (var t in taskService.GetAllTasks())
            {
                Console.WriteLine($"ID: {t.Id} | Titulo: {t.Title} | Estado: {t.Status} | Modificado: {t.UpdatedAt}");
            }
        }
    }
}