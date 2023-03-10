using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alunos.Models
{
    public class Matricula
    {
        public string? NomeMateria { get; set; }
        public int? Id { get; set; }
        [ForeignKey("Id")]
        public virtual Aluno? Aluno_Id { get; set; }

        public int? IdMateria { get; set; }
        [ForeignKey("IdMateria")]
        public virtual Materia? Materia_Id { get; set; }
    }
}
