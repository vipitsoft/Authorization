using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Configuration
{
    public class PermissionsConfiguration : IEntityTypeConfiguration<Permissions>
    {
        public void Configure(EntityTypeBuilder<Permissions> builder)
        {
            builder.ToTable("permission");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.ID).HasColumnName("id");
            builder.Property(t => t.Name).HasMaxLength(50).HasColumnName("name");
            builder.Property(t => t.Url).HasMaxLength(500).HasColumnName("url");
            builder.Property(t => t.Description).HasMaxLength(2000).HasColumnName("description");
        }
    }
}
