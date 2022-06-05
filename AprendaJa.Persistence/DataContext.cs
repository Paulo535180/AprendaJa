using AprendaJa.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendaJa.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DbContext> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<CursoModulo> CursosModulos { get; set; }
        public DbSet<TipoAula> TiposAulas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoModulo>().HasKey(CM => new { CM.ID_CURSO, CM.ID_MODULO });
        }

    }
}
