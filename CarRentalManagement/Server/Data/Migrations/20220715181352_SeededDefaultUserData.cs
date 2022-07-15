using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b416",
                column: "ConcurrencyStamp",
                value: "c6a80247-b046-454c-a45a-df04daa6153e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b417",
                column: "ConcurrencyStamp",
                value: "9fb2bea7-c558-4eba-b32f-9d9dcf3ac016");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2", 0, "93405ef4-7a8e-4c96-8cb1-852a265dbb77", "admin@admin.com", false, "System", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN1", "AQAAAAEAACcQAAAAEJwD1nifXKxVqppVRT2GiyJiI0uL9RICeJgTecQJdu3OJ1/h8WvrVs0PdXxB74JGsw==", null, false, "96641ca7-a70a-4b97-a4bb-e2b33ed39121", false, "Admin1" },
                    { "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3", 0, "24b2a900-4f60-4296-819d-9db3e9a6b644", "user@user.com", false, "System", "user", false, null, "USER@USER.COM", "USER1", "AQAAAAEAACcQAAAAEP/NAallaUuIHgMDCxavBB8klVfojt8NZ4Ldf1ADrz/9yYzaBtUOJkZuMjG5Zf9QPA==", null, false, "18119e02-7bee-4782-bedc-cc09f17d8577", false, "USER1" }
                });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9688), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9702), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9704), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9887) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9958), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9959) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9961) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9963), new DateTime(2022, 7, 15, 15, 13, 51, 881, DateTimeKind.Local).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(43), new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(46), new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(46) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(48), new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 7, 15, 15, 13, 51, 882, DateTimeKind.Local).AddTicks(51) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b416",
                column: "ConcurrencyStamp",
                value: "c2d38c07-2466-4971-b446-6219f5fd21e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b417",
                column: "ConcurrencyStamp",
                value: "d557422d-1e78-4e32-8f9f-3abc0510f4a2");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8926), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8941), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8944), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9218), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9220), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9221) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9222), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9224), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9323), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9324) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9325), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9327), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9329), new DateTime(2022, 7, 15, 11, 24, 39, 560, DateTimeKind.Local).AddTicks(9330) });
        }
    }
}
