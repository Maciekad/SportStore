using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportStore.Migrations
{
    public partial class AddSupplierConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_Opinions_OpinionId",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Reclamations_ReclamationId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_OpinionId",
                table: "People");

            migrationBuilder.DropIndex(
                name: "IX_People_ReclamationId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "OpinionId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "ReclamationId",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Reclamations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SalesmanId",
                table: "Reclamations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Reclamations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DismissalDate",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HireDate",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "HourRate",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Hours",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Salary",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ShipmentDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Opinions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reclamations_CustomerId",
                table: "Reclamations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reclamations_SalesmanId",
                table: "Reclamations",
                column: "SalesmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_SupplierId",
                table: "Orders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinions_CustomerId",
                table: "Opinions",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Opinions_People_CustomerId",
                table: "Opinions",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Suppliers_SupplierId",
                table: "Orders",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamations_People_CustomerId",
                table: "Reclamations",
                column: "CustomerId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reclamations_People_SalesmanId",
                table: "Reclamations",
                column: "SalesmanId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Opinions_People_CustomerId",
                table: "Opinions");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Suppliers_SupplierId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamations_People_CustomerId",
                table: "Reclamations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reclamations_People_SalesmanId",
                table: "Reclamations");

            migrationBuilder.DropIndex(
                name: "IX_Reclamations_CustomerId",
                table: "Reclamations");

            migrationBuilder.DropIndex(
                name: "IX_Reclamations_SalesmanId",
                table: "Reclamations");

            migrationBuilder.DropIndex(
                name: "IX_Orders_SupplierId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Opinions_CustomerId",
                table: "Opinions");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Reclamations");

            migrationBuilder.DropColumn(
                name: "SalesmanId",
                table: "Reclamations");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reclamations");

            migrationBuilder.DropColumn(
                name: "DismissalDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "HireDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "HourRate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Hours",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "People");

            migrationBuilder.DropColumn(
                name: "OrderDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipmentDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Opinions");

            migrationBuilder.AddColumn<int>(
                name: "OpinionId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReclamationId",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_People_OpinionId",
                table: "People",
                column: "OpinionId",
                unique: true,
                filter: "[OpinionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_People_ReclamationId",
                table: "People",
                column: "ReclamationId");

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
    }
}
