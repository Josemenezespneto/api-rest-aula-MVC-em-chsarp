using API_AULA_23_05_2023.Models;
using Microsoft.EntityFrameworkCore;

namespace API_AULA_23_05_2023.Data
{
    public class ContextoBD : DbContext
    {
        public ContextoBD(DbContextOptions<ContextoBD> options) : base(options)
        {

        }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}
