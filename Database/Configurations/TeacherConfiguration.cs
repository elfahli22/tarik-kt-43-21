﻿using tarik_kt_43_21.Helpers;
using tarik_kt_43_21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace tarik_kt_43_21.Database.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        private const string TableName = "cd_teacher";
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
              .HasKey(t => t.TeacherId)
              .HasName($"pk_{TableName}_teacher_id");

            builder.Property(t => t.TeacherId)
                   .ValueGeneratedOnAdd();

            builder.Property(t => t.TeacherId)
              .HasColumnName("teacher_id")
              .HasComment("Идентификатор записи студента");

            builder.Property(p => p.FirstName)
              .IsRequired()
              .HasColumnName("c_teacher_firstname")
              .HasColumnType(ColumnType.String).HasMaxLength(100);

            builder.Property(p => p.LastName)
              .IsRequired()
              .HasColumnName("c_teacher_lastname")
              .HasColumnType(ColumnType.String).HasMaxLength(100);

            builder.Property(p => p.MiddleName)
                .HasColumnName("c_teacher_middlename")
                .HasColumnType(ColumnType.String).HasMaxLength(100);

            builder.Property(p => p.DepartmentId)
              .IsRequired()
              .HasColumnName("f_department_id")
              .HasColumnType(ColumnType.Int);

            builder.ToTable(TableName)
              .HasOne(p => p.Department)
              .WithMany()
              .HasForeignKey(p => p.DepartmentId)
              .HasConstraintName("fk_f_department_id")
              .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
              .HasIndex(p => p.DepartmentId, $"idx_{TableName}_fk_f_department_id");

            builder.Navigation(p => p.Department)
              .AutoInclude();

            builder.Property(p => p.PositionId)
              .IsRequired()
              .HasColumnName("f_position_id")
              .HasColumnType(ColumnType.Int);

            builder.ToTable(TableName)
              .HasOne(p => p.Position)
              .WithMany()
              .HasForeignKey(p => p.PositionId)
              .HasConstraintName("fk_f_position_id")
              .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable(TableName)
              .HasIndex(p => p.PositionId, $"idx_{TableName}_fk_c_position_id");

            builder.Navigation(p => p.Position)
              .AutoInclude();
        }
    }
}
