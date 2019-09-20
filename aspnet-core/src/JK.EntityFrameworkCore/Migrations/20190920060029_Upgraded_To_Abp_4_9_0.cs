using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JK.Migrations
{
    public partial class Upgraded_To_Abp_4_9_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleAuthenticatorKey",
                table: "AbpUsers",
                maxLength: 20,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AppBinaryObjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    TenantId = table.Column<int>(nullable: true),
                    Bytes = table.Column<byte[]>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppBinaryObjects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppBinaryObjects");

            migrationBuilder.DropColumn(
                name: "GoogleAuthenticatorKey",
                table: "AbpUsers");
        }
    }
}
