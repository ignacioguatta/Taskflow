using System;
using TaskFlow.Services;
namespace TaskFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService taskService = new TaskService();
            taskService.CrearTarea();
        }
    }
}