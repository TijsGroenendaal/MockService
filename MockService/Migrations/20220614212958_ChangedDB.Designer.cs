﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MockService.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MockService.Migrations
{
    [DbContext(typeof(MockServiceContext))]
    [Migration("20220614212958_ChangedDB")]
    partial class ChangedDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MockService.Models.Competence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Competences");
                });

            modelBuilder.Entity("MockService.Models.CompetenceScheduleGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompetenceId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ScheduleGroupId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("ScheduleGroupId");

                    b.ToTable("CompetenceScheduleGroups");
                });

            modelBuilder.Entity("MockService.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Initials")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MockService.Models.EmployeeContract", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uuid");

                    b.Property<string>("ScheduleCompetence")
                        .HasColumnType("text");

                    b.Property<DateTime?>("TrialPeriodEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ValidFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeContracts");
                });

            modelBuilder.Entity("MockService.Models.EmployeeContractCompetence", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CompetenceId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeContractId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("validFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("validTo")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CompetenceId");

                    b.HasIndex("EmployeeContractId");

                    b.ToTable("EmployeeContractCompetences");
                });

            modelBuilder.Entity("MockService.Models.EmployeeContractExtension", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EmployeeContractId")
                        .HasColumnType("uuid");

                    b.Property<string>("Function")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LaborMinutesPerWeekMax")
                        .HasColumnType("integer");

                    b.Property<int>("LaborMinutesPerWeekMin")
                        .HasColumnType("integer");

                    b.Property<Guid>("OrganizationalUnitId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("validFrom")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("validTo")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeContractId");

                    b.HasIndex("OrganizationalUnitId");

                    b.ToTable("EmployeeContractExtensions");
                });

            modelBuilder.Entity("MockService.Models.OrganizationalUnit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("OrganizationalUnits");
                });

            modelBuilder.Entity("MockService.Models.OrganizationalUnitScheduleGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrganizationalUnitId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ScheduleGroupId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationalUnitId");

                    b.HasIndex("ScheduleGroupId");

                    b.ToTable("OrganizationalUnitScheduleGroups");
                });

            modelBuilder.Entity("MockService.Models.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("EmployeeContractId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("HasChanged")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ScheduleGroupId")
                        .HasColumnType("uuid");

                    b.Property<int>("ScheduleType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeContractId");

                    b.HasIndex("ScheduleGroupId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("MockService.Models.ScheduleGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IgnoreInCalculations")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsValid")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ScheduleGroup");
                });

            modelBuilder.Entity("MockService.Models.ScheduleGroupSchedule", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("ScheduleGroupId")
                        .HasColumnType("uuid");

                    b.Property<int>("ScheduleType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Start")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleGroupId");

                    b.ToTable("ScheduleGroupSchedule");
                });

            modelBuilder.Entity("MockService.Models.CompetenceScheduleGroup", b =>
                {
                    b.HasOne("MockService.Models.Competence", "Competence")
                        .WithMany()
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockService.Models.ScheduleGroup", null)
                        .WithMany("CompetenceScheduleGroups")
                        .HasForeignKey("ScheduleGroupId");

                    b.Navigation("Competence");
                });

            modelBuilder.Entity("MockService.Models.EmployeeContract", b =>
                {
                    b.HasOne("MockService.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("MockService.Models.EmployeeContractCompetence", b =>
                {
                    b.HasOne("MockService.Models.Competence", "Competence")
                        .WithMany()
                        .HasForeignKey("CompetenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockService.Models.EmployeeContract", "EmployeeContract")
                        .WithMany()
                        .HasForeignKey("EmployeeContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Competence");

                    b.Navigation("EmployeeContract");
                });

            modelBuilder.Entity("MockService.Models.EmployeeContractExtension", b =>
                {
                    b.HasOne("MockService.Models.EmployeeContract", "EmployeeContract")
                        .WithMany()
                        .HasForeignKey("EmployeeContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockService.Models.OrganizationalUnit", "OrganizationalUnit")
                        .WithMany()
                        .HasForeignKey("OrganizationalUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeContract");

                    b.Navigation("OrganizationalUnit");
                });

            modelBuilder.Entity("MockService.Models.OrganizationalUnitScheduleGroup", b =>
                {
                    b.HasOne("MockService.Models.OrganizationalUnit", "OrganizationalUnit")
                        .WithMany()
                        .HasForeignKey("OrganizationalUnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockService.Models.ScheduleGroup", null)
                        .WithMany("OrganizationalUnits")
                        .HasForeignKey("ScheduleGroupId");

                    b.Navigation("OrganizationalUnit");
                });

            modelBuilder.Entity("MockService.Models.Schedule", b =>
                {
                    b.HasOne("MockService.Models.EmployeeContract", "EmployeeContract")
                        .WithMany()
                        .HasForeignKey("EmployeeContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MockService.Models.ScheduleGroup", "ScheduleGroup")
                        .WithMany()
                        .HasForeignKey("ScheduleGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeContract");

                    b.Navigation("ScheduleGroup");
                });

            modelBuilder.Entity("MockService.Models.ScheduleGroupSchedule", b =>
                {
                    b.HasOne("MockService.Models.ScheduleGroup", null)
                        .WithMany("ScheduleGroupSchedules")
                        .HasForeignKey("ScheduleGroupId");
                });

            modelBuilder.Entity("MockService.Models.ScheduleGroup", b =>
                {
                    b.Navigation("CompetenceScheduleGroups");

                    b.Navigation("OrganizationalUnits");

                    b.Navigation("ScheduleGroupSchedules");
                });
#pragma warning restore 612, 618
        }
    }
}
