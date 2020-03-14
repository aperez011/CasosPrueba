using CP.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Data
{
    public class DataContext : DbContext
    {
        /*private readonly IConfiguration _conf;
        public DataContext(IConfiguration configuration)
        {
            _conf = configuration;
        }*/
        
        public DataContext(DbContextOptions<DataContext> _context) : base(_context)
        {
            //_conf = configuration;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        //{
            
        //    if (!optBuilder.IsConfigured)
        //    {
        //        var localDb = _conf["ConectionString:LocalData"];
        //        optBuilder.UseSqlServer(localDb);
        //    }
        //}

        public virtual DbSet<XmlType> XmlTypes { get; set; }
        public virtual DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<XmlType>(entity => {
                entity.ToTable("XmlType");
                entity.HasKey(e => e.Indx);

                entity.Property(e => e.Indx).HasColumnName("Indx").ValueGeneratedOnAdd();
                entity.Property(e => e.GID).HasColumnName("GID");
                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.LogDate).HasColumnName("LogDate");
                entity.Property(e => e.Name).HasColumnName("Name");
                entity.Property(e => e.Order).HasColumnName("Order");
            });
            //modelBuilder.Entity<Section>().ToTable("Section");
        }

    }
}
