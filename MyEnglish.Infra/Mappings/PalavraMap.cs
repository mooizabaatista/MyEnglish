using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEnglish.Domain;
using MyEnglish.Helper.Constants;

namespace MyEnglish.Infra.Mappings;

public class PalavraMap : IEntityTypeConfiguration<Palavra>
{
    public void Configure(EntityTypeBuilder<Palavra> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Conteudo)
            .IsRequired()
            .HasMaxLength(PalavraConstants.ConteudoMaxLength);

        builder.Property(x => x.Traducao)
            .IsRequired()
            .HasMaxLength(PalavraConstants.TraducaoMaxLength);
    }
}