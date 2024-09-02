using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class asdffa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeWork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubmissioDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Createdon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fileurl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeWork", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeWork");
        }
    }
}
