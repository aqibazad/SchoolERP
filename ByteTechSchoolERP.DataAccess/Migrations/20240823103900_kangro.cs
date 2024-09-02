using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class kangro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_SubjectModels_SubjectId",
                table: "HomeDiary");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDiary_SubjectModels_SubjectId",
                table: "HomeDiary",
                column: "SubjectId",
                principalTable: "SubjectModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_SubjectModels_SubjectId",
                table: "HomeDiary");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeDiary_SubjectModels_SubjectId",
                table: "HomeDiary",
                column: "SubjectId",
                principalTable: "SubjectModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
