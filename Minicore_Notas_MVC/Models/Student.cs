using System.ComponentModel.DataAnnotations;

namespace Minicore_Notas_MVC.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Grade> Grades { get; set; } = new();
    }
}
