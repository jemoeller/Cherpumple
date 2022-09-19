using Cherpumple.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cherpumple.Infrastructure.Persistence.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        // builder.HasOne(a => a.Avatar);
        //
        // builder.Property(a => a.Avatar).IsRequired();
        builder.Property(a => a.FirstName).IsRequired();
        builder.Property(a => a.LastName).IsRequired();
    }
}