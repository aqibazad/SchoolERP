using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class oiuytgn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TermName",
                table: "Terms",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Terms",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Terms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ClassTimetables",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffTempId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Startfrom = table.Column<TimeOnly>(type: "time", nullable: true),
                    Startto = table.Column<TimeOnly>(type: "time", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassTimetables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TimetableEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffTempId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassTimetableId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimetableEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimetableEntries_ClassTimetables_ClassTimetableId",
                        column: x => x.ClassTimetableId,
                        principalTable: "ClassTimetables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimetableEntries_ClassTimetableId",
                table: "TimetableEntries",
                column: "ClassTimetableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TimetableEntries");

            migrationBuilder.DropTable(
                name: "ClassTimetables");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Terms");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Terms",
                newName: "TermName");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Terms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);
        }
    }
}
