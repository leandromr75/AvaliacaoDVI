using System.Data.Entity;
using System.Reflection.Metadata;

namespace Alunos.Models
{
    public class DAO : DbContext
    {
        public DbSet<Aluno>? Alunos { get; set; }
        public DbSet<Materia>? Materias { get; set; }
        public DbSet<Nota>? Notas { get; set; }
        public DbSet<Matricula>? Matriculas { get; set; }
    }
}
