using System;
using System.Collections.Generic;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
   
    public class BoardConfiguration:IEntityTypeConfiguration<Board>
    {
        public void Configure(EntityTypeBuilder<Board> builder)
        {
            builder.ToTable("Boards");
            builder.Property(m => m.Id).HasDefaultValueSql("NEWID()");
            builder.Property(m => m.Created).HasDefaultValueSql("getdate()");
            builder.Property(m => m.RowVersion).IsRowVersion();
            builder.HasMany(m => m.BoarCollections).WithOne(m => m.Board).HasForeignKey(m => m.BoardId);
        }
    }
    public class CollectionConfiguration : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.ToTable("Collections");
            builder.Property(m => m.Id).HasDefaultValueSql("NEWID()");
            builder.Property(m => m.Created).HasDefaultValueSql("getdate()");
            builder.Property(m => m.RowVersion).IsRowVersion();
            builder.HasMany(m => m.CollectionItems).WithOne(m => m.Collection).HasForeignKey(m => m.CollectionId);

        }
    }
    public class CollectionItemConfiguration : IEntityTypeConfiguration<CollectionItem>
    {
        public void Configure(EntityTypeBuilder<CollectionItem> builder)
        {
            builder.ToTable("CollectionItems");
            builder.Property(m => m.Id).HasDefaultValueSql("NEWID()");
            builder.Property(m => m.Created).HasDefaultValueSql("getdate()");
            builder.Property(m => m.RowVersion).IsRowVersion();

        }
    }
}
