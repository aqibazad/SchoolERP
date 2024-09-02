using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class marks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Userid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Subject = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalMarks = table.Column<double>(type: "float", nullable: true),
                    ObtainMarks = table.Column<double>(type: "float", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percentage = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectAllocations_ClassId",
                table: "SubjectAllocations",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectAllocations_SectionId",
                table: "SubjectAllocations",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectAllocations_SubjectId",
                table: "SubjectAllocations",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_StudentId",
                table: "Marks",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectAllocations_Classes_ClassId",
                table: "SubjectAllocations",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectAllocations_Sections_SectionId",
                table: "SubjectAllocations",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectAllocations_SubjectModels_SubjectId",
                table: "SubjectAllocations",
                column: "SubjectId",
                principalTable: "SubjectModels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectAllocations_Classes_ClassId",
                table: "SubjectAllocations");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectAllocations_Sections_SectionId",
                table: "SubjectAllocations");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectAllocations_SubjectModels_SubjectId",
                table: "SubjectAllocations");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropIndex(
                name: "IX_SubjectAllocations_ClassId",
                table: "SubjectAllocations");

            migrationBuilder.DropIndex(
                name: "IX_SubjectAllocations_SectionId",
                table: "SubjectAllocations");

            migrationBuilder.DropIndex(
                name: "IX_SubjectAllocations_SubjectId",
                table: "SubjectAllocations");
        }
    }
}
