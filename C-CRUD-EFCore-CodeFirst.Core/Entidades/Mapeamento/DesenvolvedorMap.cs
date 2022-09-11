using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C_CRUD_EFCore_CodeFirst.Core.Entidades.Mapeamento
{
    public class DesenvolvedorMap : IEntityTypeConfiguration<Desenvolvedor>
    {
        public void Configure(EntityTypeBuilder<Desenvolvedor> builder)
        {
            builder.HasKey(k => new { k.Id });

            builder.Property(e => e.Id).HasMaxLength(36);
            builder.Property(e => e.Nome).HasMaxLength(120);
            builder.Property(e => e.Idade);
        }
    }
}
