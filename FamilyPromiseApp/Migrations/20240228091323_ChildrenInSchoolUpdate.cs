﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class ChildrenInSchoolUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
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
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
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
                name: "Case",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TakenBy = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReferringAgency = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentSituation = table.Column<string>(type: "TEXT", nullable: true),
                    IsHoused = table.Column<string>(type: "TEXT", nullable: true),
                    income = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmployed = table.Column<string>(type: "TEXT", nullable: true),
                    TransportMethod = table.Column<string>(type: "TEXT", nullable: true),
                    Substance = table.Column<string>(type: "TEXT", nullable: true),
                    HealthChallenge = table.Column<string>(type: "TEXT", nullable: true),
                    DomesticViolenceHistory = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IntakeModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    SubstanceIss = table.Column<string>(type: "TEXT", nullable: true),
                    TakenByNow = table.Column<string>(type: "TEXT", nullable: true),
                    TimeNow = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateToday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: true),
                    TransportMethod = table.Column<string>(type: "TEXT", nullable: true),
                    ReferralAgency = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmployed = table.Column<string>(type: "TEXT", nullable: true),
                    IsHoused = table.Column<string>(type: "TEXT", nullable: true),
                    Relationships = table.Column<string>(type: "TEXT", nullable: true),
                    WorkStudy = table.Column<string>(type: "TEXT", nullable: true),
                    AdultNum = table.Column<string>(type: "TEXT", nullable: true),
                    SSN = table.Column<int>(type: "INTEGER", nullable: false),
                    Reason = table.Column<int>(type: "INTEGER", nullable: false),
                    Reason2 = table.Column<int>(type: "INTEGER", nullable: false),
                    IDNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName1 = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    MaritalStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    SpouseLocation = table.Column<string>(type: "TEXT", nullable: true),
                    ChildSchool = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildGrade = table.Column<int>(type: "INTEGER", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdmitted = table.Column<int>(type: "INTEGER", nullable: false),
                    CompletionDate = table.Column<int>(type: "INTEGER", nullable: false),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CellPhoneNum = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhoneNum = table.Column<string>(type: "TEXT", nullable: true),
                    EmailAdd = table.Column<string>(type: "TEXT", nullable: true),
                    HomeAddress = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldMemberExists = table.Column<int>(type: "INTEGER", nullable: true),
                    AdultName = table.Column<string>(type: "TEXT", nullable: true),
                    AdultAge = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdultCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultWorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultEmail = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldChildrenExists = table.Column<int>(type: "INTEGER", nullable: true),
                    RecentHousing = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseType = table.Column<int>(type: "INTEGER", nullable: true),
                    ChildNum = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntakeModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SelectListGroup",
                columns: table => new
                {
                    Disabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
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
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
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
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldMemberExist = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseHoldNum = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultName = table.Column<string>(type: "TEXT", nullable: true),
                    AdultAge = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdultCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultWorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultEmail = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldChildrenExist = table.Column<int>(type: "INTEGER", nullable: true),
                    ChildNum = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false),
                    CaseID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Person_Case_CaseID",
                        column: x => x.CaseID,
                        principalTable: "Case",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Referral",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReferralName = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    ContactInfo = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    PersonID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referral", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Referral_Person_PersonID",
                        column: x => x.PersonID,
                        principalTable: "Person",
                        principalColumn: "ID");
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
                name: "IX_Person_CaseID",
                table: "Person",
                column: "CaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Referral_PersonID",
                table: "Referral",
                column: "PersonID");
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
                name: "IntakeModel");

            migrationBuilder.DropTable(
                name: "Referral");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "SelectListGroup");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
