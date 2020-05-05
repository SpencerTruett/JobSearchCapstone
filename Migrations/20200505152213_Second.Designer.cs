﻿// <auto-generated />
using System;
using JobSearch.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobSearch.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200505152213_Second")]
    partial class Second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JobSearch.Models.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SkillsAndCertifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Applicant");
                });

            modelBuilder.Entity("JobSearch.Models.ApplicantJob", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicantId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAccepted")
                        .HasColumnType("bit");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("JobId");

                    b.ToTable("ApplicantJob");
                });

            modelBuilder.Entity("JobSearch.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("ApplicantId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmployer")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                            AccessFailedCount = 0,
                            ApplicantId = 0,
                            CompanyId = 0,
                            ConcurrencyStamp = "047a81d4-f5b7-4747-9a9e-74a247f44bb6",
                            Email = "admin@admin.com",
                            EmailConfirmed = true,
                            FirstName = "Admina",
                            IsEmployer = false,
                            LastName = "Straytor",
                            LocationId = 0,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMgFr98ecOqHKcNzT+CHSe8y0wpP0rcyfErHfC3gTScTMqzCRkOne1lUmujsMKt/kw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("JobSearch.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUs")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("JobSearch.Models.EmploymentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmploymentType");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Full-time"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Part-time"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fixed-Term/Contract"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Commission"
                        });
                });

            modelBuilder.Entity("JobSearch.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("EmploymentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(55)")
                        .HasMaxLength(55);

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearsOfExperience")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmploymentTypeId");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("JobSearch.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alabama"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Alaska"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Arizona"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Arkansas"
                        },
                        new
                        {
                            Id = 5,
                            Name = "California"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Colorado"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Connecticut"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Delaware"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Florida"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Georgia"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Hawaii"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Idaho"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Illinois"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Indiana"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Iowa"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Kansas"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Kentucky"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Louisiana"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Maine"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Maryland"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Massachusetts"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Michigan"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Minnesota"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Mississippi"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Missouri"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Montana"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Nebraska"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Nevada"
                        },
                        new
                        {
                            Id = 29,
                            Name = "New Hampshire"
                        },
                        new
                        {
                            Id = 30,
                            Name = "New Jersey"
                        },
                        new
                        {
                            Id = 31,
                            Name = "New Mexico"
                        },
                        new
                        {
                            Id = 32,
                            Name = "New York"
                        },
                        new
                        {
                            Id = 33,
                            Name = "North Carolina"
                        },
                        new
                        {
                            Id = 34,
                            Name = "North Dakota"
                        },
                        new
                        {
                            Id = 35,
                            Name = "Ohio"
                        },
                        new
                        {
                            Id = 36,
                            Name = "Oklahoma"
                        },
                        new
                        {
                            Id = 37,
                            Name = "Oregon"
                        },
                        new
                        {
                            Id = 38,
                            Name = "Pennsylvania"
                        },
                        new
                        {
                            Id = 39,
                            Name = "Rhode Island"
                        },
                        new
                        {
                            Id = 40,
                            Name = "South Carolina"
                        },
                        new
                        {
                            Id = 41,
                            Name = "South Dakota"
                        },
                        new
                        {
                            Id = 42,
                            Name = "Tennessee"
                        },
                        new
                        {
                            Id = 43,
                            Name = "Texas"
                        },
                        new
                        {
                            Id = 44,
                            Name = "Utah"
                        },
                        new
                        {
                            Id = 45,
                            Name = "Vermont"
                        },
                        new
                        {
                            Id = 46,
                            Name = "Virginia"
                        },
                        new
                        {
                            Id = 47,
                            Name = "Washington"
                        },
                        new
                        {
                            Id = 48,
                            Name = "West Virginia"
                        },
                        new
                        {
                            Id = 49,
                            Name = "Wisconsin"
                        },
                        new
                        {
                            Id = 50,
                            Name = "Wyoming"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JobSearch.Models.ApplicantJob", b =>
                {
                    b.HasOne("JobSearch.Models.Applicant", "Applicant")
                        .WithMany()
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobSearch.Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobSearch.Models.Company", b =>
                {
                    b.HasOne("JobSearch.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JobSearch.Models.Job", b =>
                {
                    b.HasOne("JobSearch.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobSearch.Models.EmploymentType", "EmploymentType")
                        .WithMany()
                        .HasForeignKey("EmploymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JobSearch.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JobSearch.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JobSearch.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JobSearch.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
