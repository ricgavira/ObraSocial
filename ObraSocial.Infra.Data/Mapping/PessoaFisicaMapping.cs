using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ObraSocial.Domain.Entities;

namespace ObraSocial.Infra.Data.Mapping
{
    public class PessoaFisicaMapping : IEntityTypeConfiguration<PessoaFisica>
    {
        public void Configure(EntityTypeBuilder<PessoaFisica> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired();
            builder.Property(x => x.Cpf)
                .IsRequired();
            builder.Property(x => x.NomeDaMae)
                .IsRequired();
            builder.Property(x => x.DataNascimento)
                .IsRequired();

            builder.Property(x => x.Rg);
            builder.Property(x => x.NomeDoPai);
            builder.Property(x => x.Foto);
            builder.Property(x => x.Raca);
            builder.Property(x => x.Naturalidade);
            builder.Property(x => x.Nacionalidade);
            builder.Property(x => x.Sexo);
            builder.Property(x => x.Classificacao);

            builder.HasMany(x => x.Contatos)
                .WithOne(c => c.PessoaFisica)
                .HasForeignKey(x => x.PessoaFisicaId);

            builder.HasMany(x => x.Enderecos);

            builder.ToTable(nameof(PessoaFisica));
        }
    }
}