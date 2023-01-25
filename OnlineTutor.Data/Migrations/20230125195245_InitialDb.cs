using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineTutor.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsApproved = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 16, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    TeacherInfo = table.Column<string>(type: "TEXT", nullable: true),
                    Department = table.Column<string>(type: "TEXT", nullable: true),
                    TeacherPoint = table.Column<byte>(type: "INTEGER", nullable: false),
                    ResponseRange = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubjectCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubjectId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectCategories", x => x.Id);
                    table.UniqueConstraint("AK_SubjectCategories_SubjectId_CategoryId", x => new { x.SubjectId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_SubjectCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectCategories_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentText = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Point = table.Column<byte>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<string>(type: "TEXT", nullable: true),
                    StudentId = table.Column<string>(type: "TEXT", nullable: true),
                    Url = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ShowCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    TeacherId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShowCards_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Expectations = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: false),
                    ResponseTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StudentId = table.Column<string>(type: "TEXT", nullable: true),
                    ShowCardId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_ShowCards_ShowCardId",
                        column: x => x.ShowCardId,
                        principalTable: "ShowCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Requests_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectCategoryShowCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SubjectCategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShowCardId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectCategoryShowCards", x => x.Id);
                    table.UniqueConstraint("AK_SubjectCategoryShowCards_SubjectCategoryId_ShowCardId", x => new { x.SubjectCategoryId, x.ShowCardId });
                    table.ForeignKey(
                        name: "FK_SubjectCategoryShowCards_ShowCards_ShowCardId",
                        column: x => x.ShowCardId,
                        principalTable: "ShowCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectCategoryShowCards_SubjectCategories_SubjectCategoryId",
                        column: x => x.SubjectCategoryId,
                        principalTable: "SubjectCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "50029d51-368b-4b8d-9b07-b1d600440192", null, "Student Rolü", "Student", "STUDENT" },
                    { "7e1d8351-f067-45d7-bc13-aa14e44db64a", null, "Admin Rolü", "Admin", "ADMIN" },
                    { "90dac613-5a72-4bd7-8db9-dd53914a3fe9", null, "Teacher Rolü", "Teacher", "TEACHER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "IsApproved", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55dc4a34-a463-46b2-8fb3-e97a76f70cfc", 0, "İstanbul", "61e8d569-0ba2-42b1-bdf7-b27cc5474c13", new DateTime(2023, 1, 25, 22, 52, 44, 982, DateTimeKind.Local).AddTicks(7332), new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "AdminAd", "Erkek", false, false, "AdminSoyad", false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAIAAYagAAAAEJCXcesIPb2R/AzECnONfYMHPHW36+41UqeHA51UV4RZJBsNanv/vQuoeumpJNudRg==", "5555555555", false, "6b2d8b33-098f-4f15-ada4-ed9a921ebfd3", false, "admin" },
                    { "86c02fd2-67c2-4a94-8113-a751bfe9f71f", 0, "İzmir", "d666ad9d-3780-499b-a91c-3253a1b1d774", new DateTime(2023, 1, 25, 22, 52, 44, 982, DateTimeKind.Local).AddTicks(7394), new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "ogrenci@gmail.com", true, "OgrenciAd", "Erkek", false, false, "OgrenciSoyad", false, null, "OGRENCI@GMAIL.COM", "OGRENCI", "AQAAAAIAAYagAAAAEMD6r5X/sO9lWgx6jOBFiSnHJJIISNHQXOxF55qkQgOqTSHfkXMlUKitAQcfQtrjew==", "4444444444", false, "c5afaa94-ccef-487d-bb16-39ddb00486d2", false, "ogrenci" },
                    { "dc4ac19a-431c-40f1-a2df-cd49869e3559", 0, "Ankara", "15726b63-c5c4-4291-9305-a53e7b025f7c", new DateTime(2023, 1, 25, 22, 52, 44, 982, DateTimeKind.Local).AddTicks(7476), new DateTime(1985, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacher@gmail.com", true, "OgretmenAd", "Erkek", false, false, "OgretmenSoyad", false, null, "TEACHER@GMAIL.COM", "TEACHER", "AQAAAAIAAYagAAAAEDMlDiZ7HQOY26CBsv9egjoJSCYcfE+j1GqRxxEtQ8oqvimDzugVLC5vYwyYvJU5Og==", "3333333333", false, "fa78aae0-58b1-42fd-a2ec-66cf53e97e29", false, "teacher" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Bu bir açıklamadır.", "Lise", "lise" },
                    { 2, "Bu bir açıklamadır.", "İlköğretim", "ilkogretim" },
                    { 3, "Bu bir açıklamadır.", "Yazılım", "yazilim" },
                    { 4, "Bu bir açıklamadır.", "Üniversite", "universite" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Bu bir açıklamadır.", null, "Matematik", "matematik" },
                    { 2, "Bu bir açıklamadır.", null, "Fizik", "fizik" },
                    { 3, "Bu bir açıklamadır.", null, "Kimya", "kimya" },
                    { 4, "Bu bir açıklamadır.", null, "C#", "c#" },
                    { 5, "Bu bir açıklamadır.", null, "Javascript", "javascript" },
                    { 6, "Bu bir açıklamadır.", null, "Makine Mühendisliği", "makine-muhendisligi" },
                    { 7, "Bu bir açıklamadır.", null, "Bilgisayar Mühendisliği", "bilgisayar-muhendisligi" },
                    { 8, "Bu bir açıklamadır.", null, "Hayat Bilgisi", "hayat-bilgisi" },
                    { 9, "Bu bir açıklamadır.", null, "İngilizce", "ingilizce" },
                    { 10, "Bu bir açıklamadır.", null, "DotNET", "dotnet" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7e1d8351-f067-45d7-bc13-aa14e44db64a", "55dc4a34-a463-46b2-8fb3-e97a76f70cfc" },
                    { "50029d51-368b-4b8d-9b07-b1d600440192", "86c02fd2-67c2-4a94-8113-a751bfe9f71f" },
                    { "90dac613-5a72-4bd7-8db9-dd53914a3fe9", "dc4ac19a-431c-40f1-a2df-cd49869e3559" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Url" },
                values: new object[] { "86c02fd2-67c2-4a94-8113-a751bfe9f71f", null });

            migrationBuilder.InsertData(
                table: "SubjectCategories",
                columns: new[] { "Id", "CategoryId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 9 }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Department", "ResponseRange", "TeacherInfo", "TeacherPoint", "Url" },
                values: new object[] { "dc4ac19a-431c-40f1-a2df-cd49869e3559", null, null, null, (byte)0, null });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentText", "Point", "StudentId", "TeacherId", "Url" },
                values: new object[] { 1, "Mükemmel bir eğitimci.", (byte)0, "86c02fd2-67c2-4a94-8113-a751bfe9f71f", "dc4ac19a-431c-40f1-a2df-cd49869e3559", "comment-1" });

            migrationBuilder.InsertData(
                table: "ShowCards",
                columns: new[] { "Id", "Description", "IsHome", "Price", "TeacherId", "Title", "Url" },
                values: new object[,]
                {
                    { 1, "Lise, Üniversite matematik dersleri verilir.", true, 100m, "dc4ac19a-431c-40f1-a2df-cd49869e3559", "Online Matematik Dersi", "ozel-ders-1" },
                    { 2, "İngilizce anadilli hocadan ingilizce dersleri.", false, 100m, "dc4ac19a-431c-40f1-a2df-cd49869e3559", "Online İngilizce Dersi", "ozel-ders-ing" }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "ContactNumber", "Expectations", "ResponseTime", "ShowCardId", "StudentId" },
                values: new object[] { 1, "0555-555-55-55", "Kalkülüs dersi için 5 saatlik özel ders", new DateTime(2023, 1, 25, 22, 52, 45, 343, DateTimeKind.Local).AddTicks(1507), 1, "86c02fd2-67c2-4a94-8113-a751bfe9f71f" });

            migrationBuilder.InsertData(
                table: "SubjectCategoryShowCards",
                columns: new[] { "Id", "ShowCardId", "SubjectCategoryId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_StudentId",
                table: "Comments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TeacherId",
                table: "Comments",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_ShowCardId",
                table: "Requests",
                column: "ShowCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_StudentId",
                table: "Requests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ShowCards_TeacherId",
                table: "ShowCards",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCategories_CategoryId",
                table: "SubjectCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectCategoryShowCards_ShowCardId",
                table: "SubjectCategoryShowCards",
                column: "ShowCardId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SubjectCategoryShowCards");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "ShowCards");

            migrationBuilder.DropTable(
                name: "SubjectCategories");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
