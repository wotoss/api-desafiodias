using Microsoft.EntityFrameworkCore;
using api_desafio21dias.Models;

namespace api_desafio21dias.Servico
{
    public class DbContexto : DbContext
    {
        public DbContexto(DbContextOptions<DbContexto> options) : base(options){}

        public DbSet<Aluno> Alunos {get; set;}

        public DbSet<Fornecedor> Fornecedores {get; set;}
    }

}