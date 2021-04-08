using CakeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CakeShop.Data.Configuration
{
    public class ConfigLanguage : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasMaxLength(10).IsUnicode(false).IsRequired();
            builder.Property(x => x.NameLanguage).IsRequired().HasMaxLength(10);
        }
    }
}
