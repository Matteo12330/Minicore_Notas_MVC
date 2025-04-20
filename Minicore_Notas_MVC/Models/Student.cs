using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Minicore_Notas_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)] // SQLite no permite nvarchar(max), así que usamos una longitud fija
        public string Name { get; set; }

        public List<Grade> Grades { get; set; } = new();
    }
}
