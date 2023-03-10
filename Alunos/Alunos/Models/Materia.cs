using System.ComponentModel.DataAnnotations;

namespace Alunos.Models
{
    public class Materia
    {

        [Key]
        public int IdMateria { get; set; }
        
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

    }
}
