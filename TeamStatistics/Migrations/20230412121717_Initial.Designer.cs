﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamStatistics.Data;

#nullable disable

namespace TeamStatistics.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230412121717_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("TeamStatistics.Data.Entities.Commitment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DeveloperId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("DidComplete")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IncludeInData")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("JiraIssueId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SprintId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("WasInitiallyCommitted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("JiraIssueId");

                    b.HasIndex("SprintId");

                    b.ToTable("Commitments");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Developer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Entry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CommitmentId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHoliday")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IssueStatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CommitmentId");

                    b.HasIndex("IssueStatusId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.IssueStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("IssueStatuses");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Name = "In Progress"
                        },
                        new
                        {
                            Id = 1,
                            Name = "Open"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ready for Release"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ready for Test"
                        },
                        new
                        {
                            Id = 5,
                            Name = "In Test"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Done"
                        },
                        new
                        {
                            Id = 2,
                            Name = "To Do"
                        });
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.JiraIssue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRegressionBug")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("JiraProjectId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StoryPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JiraProjectId");

                    b.HasIndex("ProductId");

                    b.ToTable("JiraIssues");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.JiraProject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("JiraProjects");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.JiraSupportIssue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateCreatedUtc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateModifiedUtc")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DeveloperId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("JiraIssueId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("SprintId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TimeZone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("WasInitiallyCommitted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("JiraIssueId");

                    b.HasIndex("SprintId");

                    b.ToTable("JiraSupportIssues");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CARA"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Crisis Management"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Critical Resource Tracker"
                        },
                        new
                        {
                            Id = 4,
                            Name = "EPMM"
                        },
                        new
                        {
                            Id = 5,
                            Name = "OpenBeds"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Treatment Connection"
                        },
                        new
                        {
                            Id = 7,
                            Name = "SMART on FHIR"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Availability API"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Referral API"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Cognito"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Launcher"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Dynatrace"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Quarter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Quarters");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Sprint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("QuarterId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("QuarterId");

                    b.ToTable("Sprints");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Commitment", b =>
                {
                    b.HasOne("TeamStatistics.Data.Entities.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamStatistics.Data.Entities.JiraIssue", "JiraIssue")
                        .WithMany()
                        .HasForeignKey("JiraIssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamStatistics.Data.Entities.Sprint", "Sprint")
                        .WithMany()
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developer");

                    b.Navigation("JiraIssue");

                    b.Navigation("Sprint");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Entry", b =>
                {
                    b.HasOne("TeamStatistics.Data.Entities.Commitment", "Commitment")
                        .WithMany()
                        .HasForeignKey("CommitmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamStatistics.Data.Entities.IssueStatus", "IssueStatus")
                        .WithMany()
                        .HasForeignKey("IssueStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Commitment");

                    b.Navigation("IssueStatus");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.JiraIssue", b =>
                {
                    b.HasOne("TeamStatistics.Data.Entities.JiraProject", "JiraProject")
                        .WithMany()
                        .HasForeignKey("JiraProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamStatistics.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("JiraProject");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.JiraSupportIssue", b =>
                {
                    b.HasOne("TeamStatistics.Data.Entities.Developer", "Developer")
                        .WithMany()
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamStatistics.Data.Entities.JiraIssue", "JiraIssue")
                        .WithMany()
                        .HasForeignKey("JiraIssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TeamStatistics.Data.Entities.Sprint", "Sprint")
                        .WithMany()
                        .HasForeignKey("SprintId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Developer");

                    b.Navigation("JiraIssue");

                    b.Navigation("Sprint");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Sprint", b =>
                {
                    b.HasOne("TeamStatistics.Data.Entities.Quarter", "Quarter")
                        .WithMany("Sprints")
                        .HasForeignKey("QuarterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Quarter");
                });

            modelBuilder.Entity("TeamStatistics.Data.Entities.Quarter", b =>
                {
                    b.Navigation("Sprints");
                });
#pragma warning restore 612, 618
        }
    }
}
