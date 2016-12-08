using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCod.Migrations
{
    public partial class AddAdminUsertoBothModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Subscribers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Promotions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscribers_UserId",
                table: "Subscribers",
                column: "UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Subscribers_AspNetUsers_UserId",
                table: "Subscribers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_AspNetUsers_UserId",
                table: "Promotions");

            migrationBuilder.DropForeignKey(
                name: "FK_Subscribers_AspNetUsers_UserId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Subscribers_UserId",
                table: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_UserId",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Subscribers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Promotions");
        }
    }
}
