using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ByteTechSchoolERP.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeWork_SubjectModels_SubjectId",
                table: "HomeWork");

            migrationBuilder.DropIndex(
                name: "IX_HomeWork_SubjectId",
                table: "HomeWork");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "HomeWork");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SubjectId",
                table: "HomeWork",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_HomeWork_SubjectId",
                table: "HomeWork",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_HomeWork_SubjectModels_SubjectId",
                table: "HomeWork",
                column: "SubjectId",
                principalTable: "SubjectModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
