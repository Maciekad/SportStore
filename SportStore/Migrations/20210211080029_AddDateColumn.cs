using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportStore.Migrations
{
    public partial class AddDateColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Opinions_OpinionId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Reclamations_ReclamationId",
                table: "People");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_People_Opinions_OpinionId",
                table: "People",
                column: "OpinionId",
                principalTable: "Opinions",
                principalColumn: "OpinionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Reclamations_ReclamationId",
                table: "People",
                column: "ReclamationId",
                principalTable: "Reclamations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Opinions_OpinionId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Reclamations_ReclamationId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Orders");

            migrationBuilder.AddForeignKey(
                name: "FK_People_Opinions_OpinionId",
                table: "People",
                column: "OpinionId",
                principalTable: "Opinions",
                principalColumn: "OpinionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Reclamations_ReclamationId",
                table: "People",
                column: "ReclamationId",
                principalTable: "Reclamations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
