using tarik_kt_43_21.Helpers;
using tarik_kt_43_21.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace tarik_kt_43_21.Database.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        private const string TableName = "cd_position";
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder
                .HasKey(p => p.PositionId)
                .HasName($"pk_{TableName}_position_id");

            builder.Property(p => p.PositionId)
                  .ValueGeneratedOnAdd();


            builder.Property(p => p.PositionId)
               .HasColumnName("position_id")
               .HasComment("Идентификатор должности");

            builder.Property(p => p.Name)
              .IsRequired()
              .HasColumnName("c_position_firstname")
              .HasColumnType(ColumnType.String).HasMaxLength(150)
              .HasComment("Название должности");

            builder.ToTable(TableName);
        }
    }
}
