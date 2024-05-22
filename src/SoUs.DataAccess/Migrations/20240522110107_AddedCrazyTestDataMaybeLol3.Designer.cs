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
    [Migration("20240522110107_AddedCrazyTestDataMaybeLol3")]
    partial class AddedCrazyTestDataMaybeLol3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RolesRoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("EmployeeRoles", (string)null);
                });

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
                            AddressId = 1,
                            Name = "Middelfart Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 2,
                            AddressId = 2,
                            Name = "Roskilde Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 3,
                            AddressId = 3,
                            Name = "København Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 4,
                            AddressId = 4,
                            Name = "Viborg Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 5,
                            AddressId = 5,
                            Name = "Herning Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 6,
                            AddressId = 6,
                            Name = "Odense Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 7,
                            AddressId = 7,
                            Name = "Aalborg Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 8,
                            AddressId = 8,
                            Name = "Esbjerg Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 9,
                            AddressId = 9,
                            Name = "Horsens Plejehjem"
                        },
                        new
                        {
                            CareCenterId = 10,
                            AddressId = 10,
                            Name = "Randers Plejehjem"
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

                    b.HasData(
                        new
                        {
                            DiagnosisId = 1,
                            Description = "Alzheimer er en sygdom, der angriber hjernen og fører til hukommelsestab og nedsat kognitiv funktion.",
                            Name = "Alzheimer"
                        },
                        new
                        {
                            DiagnosisId = 2,
                            Description = "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen.",
                            Name = "Demens"
                        },
                        new
                        {
                            DiagnosisId = 3,
                            Description = "Parkinson er en kronisk sygdom, der angriber hjernen og fører til rysten, stivhed og langsomme bevægelser.",
                            Name = "Parkinson"
                        },
                        new
                        {
                            DiagnosisId = 4,
                            Description = "KOL er en samlet betegnelse for en række lungesygdomme, der gør det svært at trække vejret.",
                            Name = "KOL"
                        });
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

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            CareCenterId = 1,
                            Name = "Mette Jensen"
                        },
                        new
                        {
                            EmployeeId = 2,
                            CareCenterId = 1,
                            Name = "Lars Nielsen"
                        },
                        new
                        {
                            EmployeeId = 3,
                            CareCenterId = 1,
                            Name = "Helle Pedersen"
                        },
                        new
                        {
                            EmployeeId = 4,
                            CareCenterId = 1,
                            Name = "Mads Hansen"
                        },
                        new
                        {
                            EmployeeId = 5,
                            CareCenterId = 1,
                            Name = "Lone Madsen"
                        },
                        new
                        {
                            EmployeeId = 6,
                            CareCenterId = 1,
                            Name = "Jens Pedersen"
                        },
                        new
                        {
                            EmployeeId = 7,
                            CareCenterId = 2,
                            Name = "Lise Jensen"
                        },
                        new
                        {
                            EmployeeId = 8,
                            CareCenterId = 2,
                            Name = "Hans Nielsen"
                        },
                        new
                        {
                            EmployeeId = 9,
                            CareCenterId = 2,
                            Name = "Mette Pedersen"
                        },
                        new
                        {
                            EmployeeId = 10,
                            CareCenterId = 2,
                            Name = "Lars Hansen"
                        },
                        new
                        {
                            EmployeeId = 11,
                            CareCenterId = 2,
                            Name = "Helle Madsen"
                        },
                        new
                        {
                            EmployeeId = 12,
                            CareCenterId = 2,
                            Name = "Mads Pedersen"
                        },
                        new
                        {
                            EmployeeId = 13,
                            CareCenterId = 3,
                            Name = "Lone Hansen"
                        },
                        new
                        {
                            EmployeeId = 14,
                            CareCenterId = 3,
                            Name = "Jens Madsen"
                        },
                        new
                        {
                            EmployeeId = 15,
                            CareCenterId = 3,
                            Name = "Lise Pedersen"
                        },
                        new
                        {
                            EmployeeId = 16,
                            CareCenterId = 3,
                            Name = "Hans Jensen"
                        },
                        new
                        {
                            EmployeeId = 17,
                            CareCenterId = 4,
                            Name = "Mette Nielsen"
                        },
                        new
                        {
                            EmployeeId = 18,
                            CareCenterId = 4,
                            Name = "Lars Pedersen"
                        },
                        new
                        {
                            EmployeeId = 19,
                            CareCenterId = 4,
                            Name = "Helle Hansen"
                        },
                        new
                        {
                            EmployeeId = 20,
                            CareCenterId = 4,
                            Name = "Mads Madsen"
                        });
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MedicineId");

                    b.HasIndex("TaskId");

                    b.ToTable("Medications");

                    b.HasData(
                        new
                        {
                            MedicineId = 1,
                            Administered = false,
                            Amount = 500,
                            Name = "Paracetamol",
                            Unit = "mg"
                        },
                        new
                        {
                            MedicineId = 2,
                            Administered = true,
                            Amount = 400,
                            Name = "Ibuprofen",
                            Unit = "mg"
                        },
                        new
                        {
                            MedicineId = 3,
                            Administered = false,
                            Amount = 10,
                            Name = "Vitamin D",
                            Unit = "ug"
                        },
                        new
                        {
                            MedicineId = 4,
                            Administered = false,
                            Amount = 100,
                            Name = "Vitamin C",
                            Unit = "mg"
                        },
                        new
                        {
                            MedicineId = 5,
                            Administered = false,
                            Amount = 2,
                            Name = "Vitamin B12",
                            Unit = "ug"
                        },
                        new
                        {
                            MedicineId = 6,
                            Administered = true,
                            Amount = 200,
                            Name = "Magnesium",
                            Unit = "mg"
                        });
                });

            modelBuilder.Entity("SoUs.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("Amount")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ResidentId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Residents");

                    b.HasData(
                        new
                        {
                            ResidentId = 1,
                            BirthDate = new DateTime(1930, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Hans Hansen",
                            Notes = "Hans har brug for hjælp til at komme op om morgenen.",
                            RoomNumber = "101"
                        },
                        new
                        {
                            ResidentId = 2,
                            BirthDate = new DateTime(1940, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Lise Jensen",
                            Notes = "Lise har brug for hjælp til at tage medicin.",
                            RoomNumber = "102"
                        },
                        new
                        {
                            ResidentId = 3,
                            BirthDate = new DateTime(1950, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Mads Nielsen",
                            Notes = "Mads har brug for hjælp til at komme i bad.",
                            RoomNumber = "103"
                        },
                        new
                        {
                            ResidentId = 4,
                            BirthDate = new DateTime(1960, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Lone Pedersen",
                            Notes = "Lone har brug for hjælp til at komme i tøj.",
                            RoomNumber = "104"
                        },
                        new
                        {
                            ResidentId = 5,
                            BirthDate = new DateTime(1970, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Jens Madsen",
                            Notes = "Jens har brug for hjælp til at komme i seng.",
                            RoomNumber = "105"
                        },
                        new
                        {
                            ResidentId = 6,
                            BirthDate = new DateTime(1980, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Helle Hansen",
                            Notes = "Helle har brug for hjælp til at komme i kørestol.",
                            RoomNumber = "106"
                        },
                        new
                        {
                            ResidentId = 7,
                            BirthDate = new DateTime(1990, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Mette Jensen",
                            Notes = "Mette har brug for hjælp til at komme i stol.",
                            RoomNumber = "107"
                        },
                        new
                        {
                            ResidentId = 8,
                            BirthDate = new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CareCenterId = 1,
                            Name = "Lars Nielsen",
                            Notes = "Lars har brug for hjælp til at komme i seng.",
                            RoomNumber = "108"
                        });
                });

            modelBuilder.Entity("SoUs.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "SoSu Hjælper"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "Task planner"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Administrativ medarbejder"
                        });
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

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.HasOne("SoUs.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoUs.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
