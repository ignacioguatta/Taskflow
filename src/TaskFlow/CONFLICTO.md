# Resolución de Conflicto — Actividad 3                                                     

  ## ¿Qué pasó?

  Se generaron intencionalmente dos ramas que modificaban las mismas líneas de `Program.cs`:

  - `conflicto/version-a`: listaba tareas filtradas por estado Pendiente
  - `conflicto/version-b`: listaba todas las tareas y actualizaba el estado de una

  Al intentar mergear `conflicto/version-b` sobre `main` (que ya tenía `version-a`), Git no pudo
   decidir automáticamente qué versión conservar y detuvo el proceso.

  ## ¿Cómo se veía el conflicto?

  <<<<<<< HEAD
              taskService.ListarTareasPorEstado(TaskStatus.Pendiente);
  =======
              taskService.ListarTareas();
              taskService.UpdateStatus(1, TaskStatus.EnProgreso);
  ▎ ▎ ▎ ▎ ▎ ▎ ▎ conflicto/version-b

  ## ¿Cómo se resolvió?

  Se combinaron ambas versiones manualmente, conservando toda la funcionalidad:

  ```csharp
  taskService.ListarTareas();
  taskService.ListarTareasPorEstado(TaskStatus.Pendiente);
  taskService.UpdateStatus(1, TaskStatus.EnProgreso);

  Se eliminaron los marcadores de conflicto, se guardó el archivo y se hizo el commit de
  resolución.
  
  ¿Cómo evitar conflictos?

  1. Actualizar la rama frecuentemente — hacer git pull de main antes de empezar a trabajar cada
   día
  2. Ramas de vida corta — no dejar una rama abierta por muchos días sin mergear
  3. Comunicación con el equipo — avisar qué archivos estás modificando para no pisar el trabajo
   de otro
  4. Dividir responsabilidades por archivo — cada integrante trabaja en archivos distintos
  cuando sea posible