﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using tarik-kt-43-21.Database;

#nullable disable

namespace tarik-kt-43-21.Migrations
{
    [DbContext(typeof(TeacherDbContext))]
    partial class TeacherDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("tarik_kt_43_21.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("department_id")
                        .HasComment("Идентификатор кафедыр");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("HeaderTeacherId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("c_department_firstname")
                        .HasComment("Название кафедры");

                    b.HasKey("DepartmentId")
                        .HasName("pk_cd_department_department_id");

                    b.HasIndex("HeaderTeacherId")
                        .IsUnique();

                    b.ToTable("cd_department", (string)null);
                });

            modelBuilder.Entity("tarik_kt_43_21.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("position_id")
                        .HasComment("Идентификатор должности");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PositionId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar")
                        .HasColumnName("c_position_firstname")
                        .HasComment("Название должности");

                    b.HasKey("PositionId")
                        .HasName("pk_cd_position_position_id");

                    b.ToTable("cd_position", (string)null);
                });

            modelBuilder.Entity("tarik_kt_43_21.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("teacher_id")
                        .HasComment("Идентификатор записи преподавателя");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeacherId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int4")
                        .HasColumnName("f_department_id")
                        .HasComment("Идентификатор кафедры");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_firstname")
                        .HasComment("Имя преподавателя");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_lastname")
                        .HasComment("Фамилия преподавателя");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_teacher_middlename")
                        .HasComment("Отчество преподавателя");

                    b.Property<int>("PositionId")
                        .HasColumnType("int4")
                        .HasColumnName("f_position_id")
                        .HasComment("Идентификатор должности");

                    b.HasKey("TeacherId")
                        .HasName("pk_cd_teacher_teacher_id");

                    b.HasIndex(new[] { "DepartmentId" }, "idx_cd_teacher_fk_f_department_id");

                    b.HasIndex(new[] { "PositionId" }, "idx_cd_teacher_fk_f_position_id");

                    b.ToTable("cd_teacher", (string)null);
                });

            modelBuilder.Entity("tarik_kt_43_21.Models.Department", b =>
                {
                    b.HasOne("tarik_kt_43_21.Models.Teacher", "Teacher")
                        .WithOne()
                        .HasForeignKey("tarik_kt_43_21.Models.Department", "HeaderTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("tarik_kt_43_21.Models.Teacher", b =>
                {
                    b.HasOne("tarik_kt_43_21.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_deparment_id");

                    b.HasOne("tarik_kt_43_21.Models.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_position_id");

                    b.Navigation("Department");

                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}
