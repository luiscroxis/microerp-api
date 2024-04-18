using MicroErp.Domain.Entity.Empresas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MicroErp.Infra.Data.Repository.Orm.EntityMapConfigurations;

public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
{
    public void Configure(EntityTypeBuilder<Empresa> builder)
    {
        builder.ToTable("Empresas");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("EmpresaId")
            .IsRequired();

        builder.Property(x => x.Nome)
            .HasColumnName("Nome")
            .IsRequired();

        builder.Property(x => x.Cnpj)
            .HasColumnName("Cnpj")
            .IsRequired();

        builder.Property(x => x.InscricaoEstadual)
            .HasColumnName("InscricaoEstadual");

        builder.Property(x => x.Contato1)
            .HasColumnName("Contato1");

        builder.Property(x => x.Contato2)
            .HasColumnName("Contato2");

        builder.Property(x => x.Email)
            .HasColumnName("Email");

        builder.Property(x => x.Cliente)
            .HasColumnName("Cliente");

        builder.Property(x => x.Fornecedor)
            .HasColumnName("Fornecedor");

        builder.Property(x => x.DataCadastro)
            .HasColumnName("DataCadastro")
            .IsRequired();

        builder.Property(x => x.Ativo)
            .HasColumnName("Ativo")
            .IsRequired();
    }
}