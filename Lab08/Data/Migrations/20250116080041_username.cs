using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class username : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c1b8b28-2493-4679-88df-94faa6c33fd2", "d50eb226-ad45-43c4-84c2-893cc6ca0173" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c1b8b28-2493-4679-88df-94faa6c33fd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d50eb226-ad45-43c4-84c2-893cc6ca0173");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0ee3e7f7-8094-4ef8-86b6-c8ce0c7200d7", "0ee3e7f7-8094-4ef8-86b6-c8ce0c7200d7", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a16b66b5-5686-4d3f-838f-db2c88ae11a4", 0, "a42f37a4-05fc-491b-9985-68069e5fc6f2", "adminuser@wsei.edu.pl", true, false, null, "ADMINUSER@WSEI.EDU.PL", "ADMINUSER@WSEI.EDU.PL", "AQAAAAIAAYagAAAAECE6+GwKxaZd1GcP4PS8JLCIhLoar9hJLMwydafPN2nYDyQq20P0aSdEC8kVxPcWZQ==", null, false, "4e531746-4d4c-45ed-8d4d-2c8460d91bf8", false, "adminuser@wsei.edu.pl" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0ee3e7f7-8094-4ef8-86b6-c8ce0c7200d7", "a16b66b5-5686-4d3f-838f-db2c88ae11a4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0ee3e7f7-8094-4ef8-86b6-c8ce0c7200d7", "a16b66b5-5686-4d3f-838f-db2c88ae11a4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ee3e7f7-8094-4ef8-86b6-c8ce0c7200d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a16b66b5-5686-4d3f-838f-db2c88ae11a4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c1b8b28-2493-4679-88df-94faa6c33fd2", "8c1b8b28-2493-4679-88df-94faa6c33fd2", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d50eb226-ad45-43c4-84c2-893cc6ca0173", 0, "5482f62a-9977-4c36-9a3a-375ef58b8f80", "adminuser@wsei.edu.pl", true, false, null, "ADMINUSER@WSEI.EDU.PL", "ADMINUSER", "AQAAAAIAAYagAAAAECKjtPEfuAlpe6npGPIoPmsNo7Mj6lTIHO0J93t3YzIF3dfTr5d+N4CgBfS8t7PW+Q==", null, false, "42da9a39-b183-46e4-b552-b6195560dd64", false, "adminUser" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8c1b8b28-2493-4679-88df-94faa6c33fd2", "d50eb226-ad45-43c4-84c2-893cc6ca0173" });
        }
    }
}
