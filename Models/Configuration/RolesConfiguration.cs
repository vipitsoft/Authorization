using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.ToTable("roles");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.ID).HasColumnName("id");
            builder.Property(t => t.RoleName).HasMaxLength(100).HasColumnName("role_name");
        }
    }
}
