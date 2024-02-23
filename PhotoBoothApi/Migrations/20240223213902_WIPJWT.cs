using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoBoothApi.Migrations
{
    public partial class WIPJWT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ghi");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey", "UserId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "abc", 0, "58231629-7aee-4c72-b3b7-e6f8b2fb8f5f", "me@me.me", false, false, null, null, null, "AQAAAAEAACcQAAAAEKq+NmbfECSTf11asEauYmopNTqKy+jCKfEQKHQTyIgI8TnBFr9hpfeB/hcGKRTITw==", null, false, "42d3e0db-d1f2-40de-a7af-ee525ae1ca14", false, "Me" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "def", 0, "3cd6d47f-1472-4a60-a0c4-9cda1e0d01fe", "myself@myself.com", false, false, null, null, null, "AQAAAAEAACcQAAAAEAhVYWF5wfA5UTJRGSBaLYsST8A1WmPQxHVr5AuF45fjkvMl+rKDuQ39TlxnvFGzXg==", null, false, "b66050cf-8547-46e4-b89e-772326853df2", false, "Myself" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ghi", 0, "e29a44f6-d61b-4c08-b554-2b81390aadeb", "andi@andi.net", false, false, null, null, null, "AQAAAAEAACcQAAAAEKFVjlnVaxc1Qug8flWQKrPyf9wazLYabl4I7ILpYiZLvCf+IyXA3CYTq6gTF5hZBg==", null, false, "02f98997-4bb7-4457-8ac8-06b51ad3f679", false, "AndI" });
        }
    }
}
