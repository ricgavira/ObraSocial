using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Infra.Data.Mapping
{
    public class EstadoMapping : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .IsRequired()
                   .UseIdentityColumn();

            builder.Property(x => x.Nome)
                   .IsRequired();

            builder.Property(x => x.Sigla)
                   .IsRequired();

            builder.ToTable(nameof(Estado));
        }
    }
}
