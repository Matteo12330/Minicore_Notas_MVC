Minicore_Notas_MVC – Proyecto MVC con SQLite y despliegue en Render

Este proyecto es una aplicación web educativa desarrollada con ASP.NET Core MVC (.NET 8) que permite gestionar estudiantes, registrar calificaciones y calcular su promedio por período.  
Está diseñado como parte de un ejercicio práctico para aplicar el patrón MVC, usar Entity Framework con SQLite y desplegarlo en la nube de forma gratuita usando Render.

---

🔧 ¿Qué hace esta app?

- Permite ingresar estudiantes con sus nombres.
- Registra calificaciones por tarea, valor, fecha y a qué estudiante pertenece.
- Muestra el promedio por período (P1, P2, P3) y el resultado final.
- Informa si el estudiante necesita aprobar el siguiente período.
- Permite filtrar las calificaciones por rango de fechas.

---

📦 Tecnologías usadas:

- ASP.NET Core MVC (.NET 8)
- C# con Razor Views
- Entity Framework Core (ORM)
- Base de datos local con SQLite (`notas.db`)
- Bootstrap 5 para la interfaz
- Render.com para el despliegue gratuito

---

📚 Documentación y recursos útiles:

- [ASP.NET Core MVC – Microsoft Docs](https://learn.microsoft.com/es-es/aspnet/core/mvc/overview?view=aspnetcore-8.0)
- [Entity Framework Core Docs](https://learn.microsoft.com/en-us/ef/core/)
- [SQLite Docs](https://www.sqlite.org/index.html)
- [Cómo desplegar .NET en Render](https://www.youtube.com/watch?v=CbyVItXf6Lw)

---

🧪 Pasos realizados para crear el proyecto:

1. Se creó el proyecto en Visual Studio como aplicación ASP.NET Core MVC.
2. Se modelaron las entidades: `Student`, `Grade` y `Period` con anotaciones de validación.
3. Se creó el `ApplicationDbContext` usando EF Core con SQLite.
4. Se ejecutaron las migraciones con `Add-Migration` y `Update-Database` para generar la base `notas.db`.
5. Se creó el CRUD funcional desde el `HomeController`.
6. Se añadió Bootstrap para una interfaz amigable.
7. Se configuró un archivo `Dockerfile` para el despliegue.
8. Se subió el proyecto a GitHub y se conectó con Render.
9. Render detectó automáticamente y desplegó el sitio online.

---

📌 Video explicativo del MiniCore versión corta:
https://youtu.be/YTN1ol4u9MU?si=CTu7ZqR_fcjR_ZsE

📁 Repositorio GitHub del proyecto:
https://github.com/Matteo12330/Minicore_Notas_MVC

🌐 Link del sitio desplegado (Render):
https://minicore-notas-mvc.onrender.com

---

⚠️ IMPORTANTE: Al usar SQLite, la base de datos `notas.db` se crea automáticamente al ejecutar el proyecto por primera vez si no existe.  
Render la genera en tiempo de ejecución, por eso es importante que el `DbContext` esté bien configurado.

