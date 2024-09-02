using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SectonId",
                table: "HomeDiary",
                newName: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeDiary_ClassId",
                table: "HomeDiary",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeDiary_SectionId",
                table: "HomeDiary",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeDiary_SubjectId",
                table: "HomeDiary",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDiary_Classes_ClassId",
                table: "HomeDiary",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDiary_Sections_SectionId",
                table: "HomeDiary",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDiary_SubjectModels_SubjectId",
                table: "HomeDiary",
                column: "SubjectId",
                principalTable: "SubjectModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_Classes_ClassId",
                table: "HomeDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_Sections_SectionId",
                table: "HomeDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_SubjectModels_SubjectId",
                table: "HomeDiary");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ParentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_HomeDiary_ClassId",
                table: "HomeDiary");

            migrationBuilder.DropIndex(
                name: "IX_HomeDiary_SectionId",
                table: "HomeDiary");

            migrationBuilder.DropIndex(
                name: "IX_HomeDiary_SubjectId",
                table: "HomeDiary");

            migrationBuilder.RenameColumn(
                name: "SectionId",
                table: "HomeDiary",
                newName: "SectonId");
        }
    }
}
