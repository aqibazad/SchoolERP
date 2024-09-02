using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class thing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeDiary_Sections_SectionId",
                table: "HomeDiary");

            migrationBuilder.DropIndex(
                name: "IX_HomeDiary_SectionId",
                table: "HomeDiary");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
