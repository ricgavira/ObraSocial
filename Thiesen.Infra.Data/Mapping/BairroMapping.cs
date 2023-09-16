using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Infra.Data.Mapping
{
    public class BairroMapping : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .IsRequired()
                   .UseIdentityColumn();

            builder.Property(x => x.Nome)
                   .IsRequired();

            builder.HasOne(x => x.Cidade)
                   .WithMany(b => b.Bairros)
                   .HasForeignKey(x => x.CidadeId);

            builder.ToTable(nameof(Bairro));
        }
    }
}
