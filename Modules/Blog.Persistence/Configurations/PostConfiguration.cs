using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Persistence.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(e => e.PostID);
            builder.Property(e => e.PostID).HasColumnName("PostID");
            builder.Property(e => e.Title).HasMaxLength(255);
            builder.Property(e => e.Slug).HasMaxLength(255);
            builder.Property(e => e.Keywords).HasMaxLength(500);
            builder.Property(e => e.Description).HasMaxLength(1000);
            builder.Property(e => e.Content).HasColumnType("ntext");
            builder.Property(e => e.Excerpt).HasMaxLength(1000);
            builder.Property(e => e.Status).HasColumnName("Status");
            builder.Property(e => e.Format).HasColumnName("Format");
            builder.Property(e => e.PublishOn).HasColumnType("datetime");
        }
    }
}
