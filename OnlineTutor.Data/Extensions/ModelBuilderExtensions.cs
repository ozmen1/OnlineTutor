using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineTutor.Entity.Concrete.Identity;
using OnlineTutor.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region role-bilgileri
            List<Role> roles = new List<Role>
            {
                new Role
                {
                    Name = "Admin",
                    Description = "Admin Rolü",
                    NormalizedName = "ADMIN"
                },
                new Role
                {
                    Name = "Student",
                    Description = "Student Rolü",
                    NormalizedName = "STUDENT"
                },
                new Role
                {
                    Name = "Teacher",
                    Description = "Teacher Rolü",
                    NormalizedName = "TEACHER"
                }
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion

            #region kullanici-bilgileri
            List<User> users = new List<User>
            {
                new User
                {
                Id = "55dc4a34-a463-46b2-8fb3-e97a76f70cfc",
                FirstName = "AdminAd",
                LastName = "AdminSoyad",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1998,5,19),
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "5555555555",
                //Address = "Çek cd. Senet sk. Fatura ap.",
                City = "İstanbul"
                }
            };

            List<User> students = new List<User>
            {
                new Student
                {
                Id = "86c02fd2-67c2-4a94-8113-a751bfe9f71f",
                FirstName = "OgrenciAd",
                LastName = "OgrenciSoyad",
                UserName = "ogrenci",
                NormalizedUserName = "OGRENCI",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1985,10,29),
                Email = "ogrenci@gmail.com",
                NormalizedEmail = "OGRENCI@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "4444444444",
                //Address = "Akasya cd. Orkide sk. Gül ap.",
                City = "İzmir"
                }
            };

            List<User> teachers = new List<User>
            {
                new Teacher
                {
                Id = "dc4ac19a-431c-40f1-a2df-cd49869e3559",
                FirstName = "OgretmenAd",
                LastName = "OgretmenSoyad",
                UserName = "teacher",
                NormalizedUserName = "TEACHER",
                Gender = "Erkek",
                DateOfBirth = new DateTime(1985,10,29),
                Email = "teacher@gmail.com",
                NormalizedEmail = "TEACHER@GMAIL.COM",
                EmailConfirmed = true,
                PhoneNumber = "3333333333",
                //Address = "Akasya cd. Orkide sk. Gül ap.",
                City = "Ankara"
                }
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            #endregion

            #region parola-islemleri
            var passwordHasher = new PasswordHasher<User>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Qwe123.");
            students[0].PasswordHash = passwordHasher.HashPassword(students[0], "Qwe123.");
            teachers[0].PasswordHash = passwordHasher.HashPassword(teachers[0], "Qwe123.");
            #endregion

            #region kullanici-rol-atama-islemleri
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string>
                {
                    UserId = users[0].Id,
                    RoleId = roles.First(r => r.Name == "Admin").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = students[0].Id,
                    RoleId = roles.First(r => r.Name == "Student").Id
                },
                new IdentityUserRole<string>
                {
                    UserId = teachers[0].Id,
                    RoleId = roles.First(r => r.Name == "Teacher").Id
                }
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
        }
    }
}
