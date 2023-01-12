﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineTutor.Data.Concrete.EfCore.Contexts;

#nullable disable

namespace OnlineTutor.Data.Migrations
{
    [DbContext(typeof(OnlineTutorContext))]
    partial class OnlineTutorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bu bir açıklamadır.",
                            Name = "Lise",
                            Url = "lise"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bu bir açıklamadır.",
                            Name = "İlköğretim",
                            Url = "ilkogretim"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bu bir açıklamadır.",
                            Name = "Yazılım",
                            Url = "yazilim"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Bu bir açıklamadır.",
                            Name = "Üniversite",
                            Url = "universite"
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<byte>("Point")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Comments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CommentText = "Mükemmel bir eğitimci.",
                            Point = (byte)0,
                            StudentId = "55dc4a34-a463-46b2-8fb3-e97a76f70cfc",
                            TeacherId = "dc4ac19a-431c-40f1-a2df-cd49869e3559",
                            Url = "comment-1"
                        },
                        new
                        {
                            Id = 2,
                            CommentText = "Harika bir eğitimci.",
                            Point = (byte)0,
                            StudentId = "86c02fd2-67c2-4a94-8113-a751bfe9f71f",
                            TeacherId = "fc4ac19b-331c-90f1-z2df-xd49869e3351",
                            Url = "comment-2"
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Identity.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Request", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Expectations")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ResponseTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ShowCardId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StudentId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ShowCardId");

                    b.HasIndex("StudentId");

                    b.ToTable("Requests", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactNumber = "0555-555-55-55",
                            Expectations = "Kalkülüs dersi için 5 saatlik özel ders",
                            ResponseTime = new DateTime(2023, 1, 12, 14, 52, 14, 236, DateTimeKind.Local).AddTicks(9051),
                            ShowCardId = 1,
                            StudentId = "55dc4a34-a463-46b2-8fb3-e97a76f70cfc"
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.ShowCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsHome")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeacherId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ShowCards", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lise, Üniversite matematik dersleri verilir.",
                            IsHome = true,
                            Price = 100m,
                            SubjectId = 1,
                            TeacherId = "dc4ac19a-431c-40f1-a2df-cd49869e3559",
                            Title = "Online Matematik Dersi",
                            Url = "ozel-ders-1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "İngilizce anadilli hocadan ingilizce dersleri.",
                            IsHome = false,
                            Price = 100m,
                            SubjectId = 3,
                            TeacherId = "fc4ac19b-331c-90f1-z2df-xd49869e3351",
                            Title = "Online İngilizce Dersi",
                            Url = "ozel-ders-ing"
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Subjects", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Bu bir açıklamadır.",
                            Name = "Matematik",
                            Url = "matematik"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Bu bir açıklamadır.",
                            Name = "Fizik",
                            Url = "fizik"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bu bir açıklamadır.",
                            Name = "Kimya",
                            Url = "kimya"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Bu bir açıklamadır.",
                            Name = "C#",
                            Url = "c#"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Bu bir açıklamadır.",
                            Name = "Javascript",
                            Url = "javascript"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Bu bir açıklamadır.",
                            Name = "Makine Mühendisliği",
                            Url = "makine-muhendisligi"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Bu bir açıklamadır.",
                            Name = "Bilgisayar Mühendisliği",
                            Url = "bilgisayar-muhendisligi"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Bu bir açıklamadır.",
                            Name = "Hayat Bilgisi",
                            Url = "hayat-bilgisi"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Bu bir açıklamadır.",
                            Name = "İngilizce",
                            Url = "ingilizce"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Bu bir açıklamadır.",
                            Name = "DotNET",
                            Url = "dotnet"
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.SubjectCategory", b =>
                {
                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SubjectId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubjectCategories", (string)null);

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 2,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 3,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 9,
                            CategoryId = 1
                        },
                        new
                        {
                            SubjectId = 1,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 3,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 9,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 8,
                            CategoryId = 2
                        },
                        new
                        {
                            SubjectId = 6,
                            CategoryId = 4
                        },
                        new
                        {
                            SubjectId = 7,
                            CategoryId = 4
                        },
                        new
                        {
                            SubjectId = 10,
                            CategoryId = 4
                        },
                        new
                        {
                            SubjectId = 4,
                            CategoryId = 3
                        },
                        new
                        {
                            SubjectId = 5,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Student", b =>
                {
                    b.HasBaseType("OnlineTutor.Entity.Concrete.Identity.User");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "86c02fd2-67c2-4a94-8113-a751bfe9f71f",
                            AccessFailedCount = 0,
                            City = "Kocaeli",
                            ConcurrencyStamp = "adcc512f-383c-45dd-83e2-fdf9b22f5f9e",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 52, 14, 236, DateTimeKind.Local).AddTicks(6374),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "keremozmen34@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Kerem",
                            IsApproved = false,
                            IsDeleted = false,
                            LastName = "Özmen",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f25eaae-b556-4973-af24-3230b60e6432",
                            TwoFactorEnabled = false,
                            Url = "universite-ogrencisi"
                        },
                        new
                        {
                            Id = "55dc4a34-a463-46b2-8fb3-e97a76f70cfc",
                            AccessFailedCount = 0,
                            City = "İstanbul",
                            ConcurrencyStamp = "897a349e-e3ce-4288-9806-953952eacf59",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 52, 14, 236, DateTimeKind.Local).AddTicks(6399),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example@example.com",
                            EmailConfirmed = false,
                            FirstName = "Jane",
                            IsApproved = false,
                            IsDeleted = false,
                            LastName = "Doe",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0f1732e6-4b45-4b77-b530-b31459901b24",
                            TwoFactorEnabled = false,
                            Url = "lise-ogrencisi"
                        });
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Teacher", b =>
                {
                    b.HasBaseType("OnlineTutor.Entity.Concrete.Identity.User");

                    b.Property<string>("Department")
                        .HasColumnType("TEXT");

                    b.Property<string>("ResponseRange")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeacherInfo")
                        .HasColumnType("TEXT");

                    b.Property<byte>("TeacherPoint")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.ToTable("Teachers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dc4ac19a-431c-40f1-a2df-cd49869e3559",
                            AccessFailedCount = 0,
                            City = "İstanbul",
                            ConcurrencyStamp = "45b10ea0-0fb3-4feb-9f4c-431bf22be3c6",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 52, 14, 236, DateTimeKind.Local).AddTicks(4789),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "keremozmentr@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Kerem",
                            IsApproved = false,
                            IsDeleted = false,
                            LastName = "Özmen",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bf5c5ae8-e6a1-47a9-b120-c2512b3e8a81",
                            TwoFactorEnabled = false,
                            TeacherInfo = "Deneyimli",
                            TeacherPoint = (byte)0,
                            Url = "deneyimli"
                        },
                        new
                        {
                            Id = "fc4ac19b-331c-90f1-z2df-xd49869e3351",
                            AccessFailedCount = 0,
                            City = "İstanbul",
                            ConcurrencyStamp = "bc90ae6d-f1c3-4c2c-b60a-eaa2e29d59ac",
                            CreatedDate = new DateTime(2023, 1, 12, 14, 52, 14, 236, DateTimeKind.Local).AddTicks(4848),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "example@example.com",
                            EmailConfirmed = false,
                            FirstName = "John",
                            IsApproved = false,
                            IsDeleted = false,
                            LastName = "Doe",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "06153ebf-c5f0-44e7-a55b-2bca6e020c18",
                            TwoFactorEnabled = false,
                            TeacherInfo = "Deneyimsiz",
                            TeacherPoint = (byte)0,
                            Url = "deneyimsiz"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Comment", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Student", "Student")
                        .WithMany("Comments")
                        .HasForeignKey("StudentId");

                    b.HasOne("OnlineTutor.Entity.Concrete.Teacher", "Teacher")
                        .WithMany("Comments")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Request", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.ShowCard", "ShowCard")
                        .WithMany("Requests")
                        .HasForeignKey("ShowCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTutor.Entity.Concrete.Student", "Student")
                        .WithMany("Requests")
                        .HasForeignKey("StudentId");

                    b.Navigation("ShowCard");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.ShowCard", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTutor.Entity.Concrete.Teacher", "Teacher")
                        .WithMany("ShowCards")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.SubjectCategory", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Category", "Category")
                        .WithMany("SubjectCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineTutor.Entity.Concrete.Subject", "Subject")
                        .WithMany("SubjectCategories")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Student", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.User", null)
                        .WithOne()
                        .HasForeignKey("OnlineTutor.Entity.Concrete.Student", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Teacher", b =>
                {
                    b.HasOne("OnlineTutor.Entity.Concrete.Identity.User", null)
                        .WithOne()
                        .HasForeignKey("OnlineTutor.Entity.Concrete.Teacher", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Category", b =>
                {
                    b.Navigation("SubjectCategories");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.ShowCard", b =>
                {
                    b.Navigation("Requests");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Subject", b =>
                {
                    b.Navigation("SubjectCategories");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Student", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Requests");
                });

            modelBuilder.Entity("OnlineTutor.Entity.Concrete.Teacher", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("ShowCards");
                });
#pragma warning restore 612, 618
        }
    }
}
