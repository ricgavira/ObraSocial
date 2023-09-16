using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Infra.Data.Mapping
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .IsRequired()
                   .UseIdentityColumn();

            builder.Property(x => x.Nome)
                   .IsRequired();

            builder.HasOne(x => x.Estado)
                   .WithMany(e => e.Cidades)
                   .HasForeignKey(x => x.EstadoId);

            builder.ToTable(nameof(Cidade));
        }
    }
}
