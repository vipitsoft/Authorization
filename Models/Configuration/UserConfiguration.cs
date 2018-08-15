using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("user");

            builder.HasKey(t => t.ID);

            builder.Property(t => t.ID).HasColumnName("id");
            builder.Property(t => t.UserName).HasMaxLength(100).HasColumnName("user_name");
            builder.Property(t => t.Password).HasMaxLength(100).HasColumnName("password");
            builder.Property(t => t.RoleID).HasColumnName("role_id");
            builder.Ignore(t => t.AuthenticationType);
        }
    }
}
