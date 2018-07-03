﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Domain;

namespace WebApi.Migrations
{
    [DbContext(typeof(DomainContext))]
    [Migration("20180703110919_Issue")]
    partial class Issue
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("tomware.Microwf.Engine.Workflow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee");

                    b.Property<DateTime?>("Completed");

                    b.Property<int>("CorrelationId");

                    b.Property<DateTime?>("DueDate");

                    b.Property<DateTime>("Started");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Workflow");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.Holiday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee")
                        .IsRequired();

                    b.Property<DateTime?>("From");

                    b.Property<string>("Requester")
                        .IsRequired();

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Superior");

                    b.Property<DateTime?>("To");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Holiday");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.HolidayMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<int>("HolidayId");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("HolidayId");

                    b.ToTable("HolidayMessage");
                });

            modelBuilder.Entity("WebApi.Workflows.Issue.Issue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Assignee")
                        .IsRequired();

                    b.Property<string>("Description");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<string>("Type")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Issue");
                });

            modelBuilder.Entity("WebApi.Workflows.Holiday.HolidayMessage", b =>
                {
                    b.HasOne("WebApi.Workflows.Holiday.Holiday", "Holiday")
                        .WithMany("Messages")
                        .HasForeignKey("HolidayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
