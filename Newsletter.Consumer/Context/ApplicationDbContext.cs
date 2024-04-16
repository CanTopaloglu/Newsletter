using Microsoft.EntityFrameworkCore;
using Newsletter.Consumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Consumer.Context;
internal sealed class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseInMemoryDatabase("MyDb");
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-SAAVPLI\\SQLEXPRESS;Initial Catalog=NewsletterDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    public DbSet<Blog> Blogs { get; set; }
}
