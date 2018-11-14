using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Persistence.Configurations
{
    public class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            builder.HasKey(x => new { x.PostID, x.CategoryID });

            builder.Property(x => x.PostID).HasColumnName("PostID");
            builder.Property(x => x.CategoryID).HasColumnName("CategoryID");

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PostCategories)
                .HasForeignKey(d => d.PostID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostCategories_Posts");

            builder.HasOne(d => d.Category)
                .WithMany(p => p.PostCategories)
                .HasForeignKey(d => d.CategoryID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PostCategories_Categories");
        }
    }
}
