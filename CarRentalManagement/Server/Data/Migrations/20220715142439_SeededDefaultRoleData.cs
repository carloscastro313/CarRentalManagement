using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c029105b-76dc-485d-9975-2029cf13b416", "c2d38c07-2466-4971-b446-6219f5fd21e9", "User", "USER" },
                    { "c029105b-76dc-485d-9975-2029cf13b417", "d557422d-1e78-4e32-8f9f-3abc0510f4a2", "Administrator", "ADMINISTRATOR" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b416");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b417");

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2777), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2786) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2792), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3007), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3088), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3091) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3093) });
        }
    }
}
