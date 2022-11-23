using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09aa7111-3b46-4cee-ac94-6ddd9a3f1212", "e1982b3a-3d85-4e6a-ac57-4cec1e762581", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5a8dfbbe-eada-451e-ab35-7ff5cfb46624", "9200daa8-1714-4c2b-80ae-26045b0e513f", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cc51540-6e4a-4a6c-935c-2d135167054d", "5a8a5917-0576-431a-80df-7fa76dd84682", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09aa7111-3b46-4cee-ac94-6ddd9a3f1212");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a8dfbbe-eada-451e-ab35-7ff5cfb46624");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cc51540-6e4a-4a6c-935c-2d135167054d");
        }
    }
}
