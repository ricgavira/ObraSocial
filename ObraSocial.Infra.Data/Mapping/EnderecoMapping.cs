using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Infra.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .IsRequired()
                   .UseIdentityColumn();

            builder.Property(x => x.Nome)
                   .IsRequired();

            builder.Property(x => x.Numero)
                   .IsRequired();

            builder.Property(x => x.Cep)
                   .IsRequired();

            builder.Property(x => x.TipoEndereco)
                   .IsRequired();

            builder.HasOne(x => x.Bairro);

            builder.ToTable(nameof(Endereco));
        }
    }
}
