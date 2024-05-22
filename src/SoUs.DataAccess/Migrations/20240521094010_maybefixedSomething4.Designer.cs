﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoUs.DataAccess;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240521094010_maybefixedSomething4")]
    partial class maybefixedSomething4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeTask", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TasksTaskId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "TasksTaskId");

                    b.HasIndex("TasksTaskId");

                    b.ToTable("TaskEmployees", (string)null);
                });

            modelBuilder.Entity("SoUs.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            City = "Middelfart",
                            State = "Syddanmark",
                            Street = "Solsikkevej 55",
                            ZipCode = "5500"
                        },
                        new
                        {
                            AddressId = 2,
                            City = "Roskilde",
                            State = "Sjælland",
                            Street = "Roskildevej 12",
                            ZipCode = "4000"
                        },
                        new
                        {
                            AddressId = 3,
                            City = "København",
                            State = "Hovedstaden",
                            Street = "Hovedgaden 1",
                            ZipCode = "1000"
                        },
                        new
                        {
                            AddressId = 4,
                            City = "Viborg",
                            State = "Midtjylland",
                            Street = "Viborgvej 5",
                            ZipCode = "8800"
                        },
                        new
                        {
                            AddressId = 5,
                            City = "Herning",
                            State = "Midtjylland",
                            Street = "Herningvej 10",
                            ZipCode = "7400"
                        },
                        new
                        {
                            AddressId = 6,
                            City = "Odense",
                            State = "Syddanmark",
                            Street = "Odensevej 15",
                            ZipCode = "5000"
                        },
                        new
                        {
                            AddressId = 7,
                            City = "Aalborg",
                            State = "Nordjylland",
                            Street = "Aalborgvej 20",
                            ZipCode = "9000"
                        },
                        new
                        {
                            AddressId = 8,
                            City = "Esbjerg",
                            State = "Syddanmark",
                            Street = "Esbjergvej 25",
                            ZipCode = "6700"
                        },
                        new
                        {
                            AddressId = 9,
                            City = "Horsens",
                            State = "Midtjylland",
                            Street = "Horsensvej 30",
                            ZipCode = "8700"
                        },
                        new
                        {
                            AddressId = 10,
                            City = "Randers",
                            State = "Midtjylland",
                            Street = "Randersvej 35",
                            ZipCode = "8900"
                        });
                });

            modelBuilder.Entity("SoUs.Entities.CareCenter", b =>
                {
                    b.Property<int>("CareCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareCenterId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareCenterId");

                    b.HasIndex("AddressId");

                    b.ToTable("CareCenters");

                    b.HasData(
                        new
                        {
                            CareCenterId = 1,
                            AddressId = 4,
                            Name = "GGM (Glade Gamle Mennesker)"
                        },
                        new
                        {
                            CareCenterId = 2,
                            AddressId = 8,
                            Name = "Hjemmet"
                        },
                        new
                        {
                            CareCenterId = 3,
                            AddressId = 5,
                            Name = "Smilets Hus"
                        },
                        new
                        {
                            CareCenterId = 4,
                            AddressId = 2,
                            Name = "SFG (Sjov For Gamle)"
                        },
                        new
                        {
                            CareCenterId = 5,
                            AddressId = 1,
                            Name = "Solskinshjemmet"
                        },
                        new
                        {
                            CareCenterId = 6,
                            AddressId = 3,
                            Name = "Hyggehuset"
                        },
                        new
                        {
                            CareCenterId = 7,
                            AddressId = 6,
                            Name = ""
                        });
                });

            modelBuilder.Entity("SoUs.Entities.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("SoUs.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SoUs.Entities.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"));

                    b.Property<bool>("Administered")
                        .HasMaxLength(255)
                        .HasColumnType("bit");

                    b.Property<int>("Amount")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MedicineId");

                    b.HasIndex("TaskId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("SoUs.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("SoUs.Entities.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidentId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("SoUs.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RoleId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SoUs.Entities.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("TaskId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("EmployeeTask", b =>
                {
                    b.HasOne("SoUs.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoUs.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoUs.Entities.CareCenter", b =>
                {
                    b.HasOne("SoUs.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SoUs.Entities.Diagnosis", b =>
                {
                    b.HasOne("SoUs.Entities.Resident", null)
                        .WithMany("Diagnoses")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SoUs.Entities.Employee", b =>
                {
                    b.HasOne("SoUs.Entities.CareCenter", "CareCenter")
                        .WithMany()
                        .HasForeignKey("CareCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CareCenter");
                });

            modelBuilder.Entity("SoUs.Entities.Medicine", b =>
                {
                    b.HasOne("SoUs.Entities.Task", null)
                        .WithMany("Medicines")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("SoUs.Entities.Prescription", b =>
                {
                    b.HasOne("SoUs.Entities.Resident", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SoUs.Entities.Resident", b =>
                {
                    b.HasOne("SoUs.Entities.CareCenter", null)
                        .WithMany("Residents")
                        .HasForeignKey("CareCenterId");
                });

            modelBuilder.Entity("SoUs.Entities.Role", b =>
                {
                    b.HasOne("SoUs.Entities.Employee", null)
                        .WithMany("Roles")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("SoUs.Entities.Task", b =>
                {
                    b.HasOne("SoUs.Entities.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("SoUs.Entities.CareCenter", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("SoUs.Entities.Employee", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("SoUs.Entities.Resident", b =>
                {
                    b.Navigation("Diagnoses");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("SoUs.Entities.Task", b =>
                {
                    b.Navigation("Medicines");
                });
#pragma warning restore 612, 618
        }
    }
}
