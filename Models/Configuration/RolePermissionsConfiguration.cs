using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Configuration
{
    public class RolePermissionsConfiguration : IEntityTypeConfiguration<RolePermissions>
    {
        public void Configure(EntityTypeBuilder<RolePermissions> builder)
        {
            builder.ToTable("role_permission");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.ID).HasColumnName("id");
            builder.Property(t => t.RoleID).HasColumnName("role_id");
            builder.Property(t => t.PermiID).HasColumnName("permi_id");
        }
    }
}
