using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ExamMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TermId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SeactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Session = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddExamDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamLists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExamCenter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BodyText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrintingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HeaderImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightLogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeftSignUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleSignUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RightSignUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTemplates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExamTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExamTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaximumPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinimumPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TermName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamLists");

            migrationBuilder.DropTable(
                name: "ExamTemplates");

            migrationBuilder.DropTable(
                name: "ExamTypes");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Terms");
        }
    }
}
