﻿// <auto-generated />
using ClinicAPI.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicAPI.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClinicAPI.Entity.DoctorService", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ServiceId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("DoctorServices");
                });

<<<<<<< HEAD
            modelBuilder.Entity("ClinicAPI.Entity.Medicine", b =>
                {
                    b.Property<string>("IdMedicine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("NameMedicine")
                        .HasColumnType("text");

                    b.Property<string>("PriceMedicine")
                        .HasColumnType("text");

                    b.Property<string>("Quantily")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<string>("UseMedicine")
                        .HasColumnType("text");

                    b.HasKey("IdMedicine");

                    b.ToTable("medicines");
                });

            modelBuilder.Entity("ClinicAPI.Entity.MedicinePrescription", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("IdMedicine")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("IdPrescription")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<int>("QuantilyMedicine")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PreMedicine");
                });

=======
>>>>>>> 38e20eabbc43b4bb1c7983053b97dcf501223b5b
            modelBuilder.Entity("ClinicAPI.Entity.Prescription", b =>
                {
                    b.Property<string>("IdMedicine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

<<<<<<< HEAD
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<byte[]>("Id")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<byte[]>("IdSchedule")
                        .HasColumnType("varbinary(16)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

=======
>>>>>>> 38e20eabbc43b4bb1c7983053b97dcf501223b5b
                    b.Property<string>("NameMedicine")
                        .HasColumnType("text");

                    b.Property<string>("PriceMedicine")
                        .HasColumnType("text");

<<<<<<< HEAD
                    b.Property<string>("Quantily")
                        .HasColumnType("text");

                    b.Property<double>("TimeStamp")
                        .HasColumnType("double");
=======
                    b.Property<int>("Quantily")
                        .HasColumnType("int");
>>>>>>> 38e20eabbc43b4bb1c7983053b97dcf501223b5b

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.Property<string>("UseMedicine")
                        .HasColumnType("text");

                    b.HasKey("IdMedicine");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("ClinicAPI.Entity.Revenue", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.Property<string>("ScheduleId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<long>("Time")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Revenues");
                });

            modelBuilder.Entity("ClinicAPI.Entity.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ClinicAPI.Entity.Schedule", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("DateTimeStamp")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ServiceId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("ClinicAPI.Entity.Service", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ClinicAPI.Entity.UserPeople", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("IdentityCard")
                        .HasColumnType("text");

                    b.Property<string>("Job")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Note1")
                        .HasColumnType("text");

                    b.Property<string>("Note2")
                        .HasColumnType("text");

                    b.Property<string>("PassWord")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserPeoples");
                });

            modelBuilder.Entity("ClinicAPI.Entity.UserRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
