using System;
using System.Collections.Generic;
using System.Text;
using TaskFlow.Models;
using TaskStatus = TaskFlow.Models.TaskStatus;

namespace TaskFlow.Services
{
    public class TaskService
    {
        private List<TaskItem> _tasks = new List<TaskItem>();
        private int _nextId = 1;

        public void CrearTarea()
        {
            string continuar;

            do
            {
                try
                {
                    Console.WriteLine("Ingrese el título de la tarea:");
                    string title = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(title))
                        throw new ArgumentException("El título no puede estar vacío.");

                    Console.WriteLine("Ingrese la descripción de la tarea:");
                    string description = Console.ReadLine();

                    Console.WriteLine("Ingrese el responsable de la tarea:");
                    string responsible = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(responsible))
                        throw new ArgumentException("El responsable no puede estar vacío.");

                    TaskItem newTask = new TaskItem
                    {
                        Id = _nextId++,
                        Title = title,
                        Description = description,
                        Responsible = responsible,
                        Status = TaskStatus.Pendiente,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now
                    };

                    _tasks.Add(newTask);

                    Console.WriteLine($"\nTarea ID: {newTask.Id}" +
                                      $"\nTítulo: {newTask.Title}" +
                                      $"\nDescripción: {newTask.Description}" +
                                      $"\nResponsable: {newTask.Responsible}" +
                                      $"\nFecha de creación: {newTask.CreatedAt}" +
                                      $"\nEstado: {newTask.Status}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Dato inválido: {ex.Message}");
                    _nextId--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                }

                Console.WriteLine("\n¿Desea crear otra tarea? (s/n):");
                continuar = Console.ReadLine().ToLower();

                while (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("Opción no válida. Ingrese 's' o 'n':");
                    continuar = Console.ReadLine().ToLower();
                }

            } while (continuar == "s");

            Console.WriteLine($"\nGracias por usar TaskFlow. Se crearon {_tasks.Count} tarea/s. ¡Hasta luego!");
        }
    }
}