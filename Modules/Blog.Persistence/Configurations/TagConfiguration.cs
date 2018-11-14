using Blog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Persistence.Configurations
{
    public class TagConfiguration: IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(e => e.TagID);
            builder.Property(e => e.TagID).HasColumnName("TagID");
            builder.Property(e => e.TagName)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
