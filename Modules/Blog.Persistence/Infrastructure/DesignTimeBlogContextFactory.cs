using Blog.Persistence.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Blog.Persistence.Infrastructure
{
    public class DesignTimeBlogContextFactory : DesignTimeDbContextFactoryBase<BlogContext>
    {
        protected override string GetHostPath(string[] args)
        {
            var basePath = Directory.GetCurrentDirectory() + string.Format("{0}..{0}Host", Path.DirectorySeparatorChar);
            return basePath;
        }

        protected override BlogContext CreateNewInstance(DbContextOptions<BlogContext> options)
        {
            return new BlogContext(options);
        }
    }
}
