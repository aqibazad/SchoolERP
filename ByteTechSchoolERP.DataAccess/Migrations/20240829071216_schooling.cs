using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class schooling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "HomeWork",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_ClassId",
                table: "HomeWork",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_SectionId",
                table: "HomeWork",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_StudentId",
                table: "HomeWork",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_SubjectId",
                table: "HomeWork",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeDiary_SectionId",
                table: "HomeDiary",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDiary_Sections_SectionId",
                table: "HomeDiary",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_Classes_ClassId",
                table: "HomeWork",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_Sections_SectionId",
                table: "HomeWork",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_Students_StudentId",
                table: "HomeWork",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_SubjectModels_SubjectId",
                table: "HomeWork",
                column: "SubjectId",
                principalTable: "SubjectModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_Sections_SectionId",
                table: "HomeDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_Classes_ClassId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_Sections_SectionId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_Students_StudentId",
                table: "HomeWork");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_SubjectModels_SubjectId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_ClassId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_SectionId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_StudentId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_SubjectId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeDiary_SectionId",
                table: "HomeDiary");

            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "HomeWork");
        }
    }
}
