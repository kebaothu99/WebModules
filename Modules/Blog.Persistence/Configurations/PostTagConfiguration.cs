using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Persistence.Configurations
{
    public class PostTagConfiguration : IEntityTypeConfiguration<PostTag>
    {
        public void Configure(EntityTypeBuilder<PostTag> builder)
        {
            builder.HasKey(e => new { e.PostID, e.TagID });

            builder.Property(e => e.PostID).HasColumnName("PostID");
            builder.Property(e => e.TagID).HasColumnName("TagID");

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PostTags)
                .HasForeignKey(d => d.PostID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostTags_Posts");

            builder.HasOne(d => d.Tag)
                .WithMany(p => p.PostTags)
                .HasForeignKey(d => d.TagID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostTags_Tags");
        }
    }
}
