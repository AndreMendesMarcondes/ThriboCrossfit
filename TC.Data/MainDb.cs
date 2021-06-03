using Microsoft.EntityFrameworkCore;
using TC.Domain;

namespace TC.Data
{
    public class MainDb : DbContext
    {
        public MainDb(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
