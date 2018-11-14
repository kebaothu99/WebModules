using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.CategoryID);
            builder.Property(e => e.CategoryID).HasColumnName("CategoryID");
            builder.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasData(new Category() { CategoryID = 1, CategoryName = "Uncategorized" });
        }
    }
}
