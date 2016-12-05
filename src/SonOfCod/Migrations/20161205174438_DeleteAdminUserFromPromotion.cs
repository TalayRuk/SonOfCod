using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCod.Migrations
{
    public partial class DeleteAdminUserFromPromotion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_AspNetUsers_UserId",
                table: "Promotions");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_UserId",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Promotions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Promotions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_UserId",
                table: "Promotions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Promotions_AspNetUsers_UserId",
                table: "Promotions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
