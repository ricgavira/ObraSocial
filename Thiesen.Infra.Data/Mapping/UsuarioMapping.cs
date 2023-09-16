using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Infra.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                   .IsRequired()
                   .UseIdentityColumn();

            builder.Property(x => x.Nome)
                   .IsRequired();

            builder.Property(x => x.Login)
                   .IsRequired();

            builder.Property(x => x.Password)
                   .IsRequired();

            builder.ToTable(nameof(Usuario));
        }
    }
}