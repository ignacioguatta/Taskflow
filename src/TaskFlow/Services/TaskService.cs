using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFlow.Services
{
    internal class TaskService
    {
        public void CrearTarea()
        {   
        Console.WriteLine("Ingrese el título de la tarea:");
        string title = Console.ReadLine();  
        Console.WriteLine("Ingrese la descripción de la tarea:");
        string description = Console.ReadLine();
        Console.WriteLine("Ingrese el responsable de la tarea:");
        string responsible = Console.ReadLine();


        }
    }
}
