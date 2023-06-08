using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ARSoftware.Contpaqi.Add.Sql.Models.DocumentContent;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts
{
    public partial class ContpaqiAddDocumentContentDbContext : DbContext
    {
        public ContpaqiAddDocumentContentDbContext()
        {
        }

        public ContpaqiAddDocumentContentDbContext(DbContextOptions<ContpaqiAddDocumentContentDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DocumentContent> DocumentContent { get; set; } = null!;
        public virtual DbSet<MyCompanyProgObj> MyCompanyProgObj { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Modern_Spanish_CI_AS");

            modelBuilder.Entity<DocumentContent>(entity =>
            {
                entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            });

            modelBuilder.Entity<MyCompanyProgObj>(entity =>
            {
                entity.HasIndex(e => e.NameObj, "IC_MyCompanyProgObj")
                    .IsClustered();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
