using System;
using System.Collections.Generic;
using ARSoftware.Contpaqi.Add.Sql.Models.DocumentContent;
using Microsoft.EntityFrameworkCore;

namespace ARSoftware.Contpaqi.Add.Sql.Contexts;

public partial class ContpaqiAddDocumentContentDbContext : DbContext
{
    public ContpaqiAddDocumentContentDbContext(DbContextOptions<ContpaqiAddDocumentContentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DocumentContent> DocumentContent { get; set; }

    public virtual DbSet<MyCompanyProgObj> MyCompanyProgObj { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<DocumentContent>(entity =>
        {
            entity.HasKey(e => e.GuidDocument);

            entity.HasIndex(e => e.GuidDocument, "IXFK_DocumentContent");

            entity.Property(e => e.GuidDocument).ValueGeneratedNever();
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FileName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubDirectory)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MyCompanyProgObj>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.NameObj, "IC_MyCompanyProgObj").IsClustered();

            entity.HasIndex(e => new { e.NameObj, e.Ver }, "INC_MyCompanyProgObj");

            entity.Property(e => e.NameObj)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Ver)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.XType)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
