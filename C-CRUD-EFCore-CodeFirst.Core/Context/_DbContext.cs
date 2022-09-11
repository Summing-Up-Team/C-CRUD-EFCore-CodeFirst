using C_CRUD_EFCore_CodeFirst.Core.Entidades;
using C_CRUD_EFCore_CodeFirst.Core.Entidades.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace C_CRUD_EFCore_CodeFirst.Core.Context
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder) 
        {
            builder.ApplyConfiguration(new DesenvolvedorMap());

            base.OnModelCreating(builder);
        }

        public DbSet<Desenvolvedor> Desenvolvedor { get; set; }
    }
}
