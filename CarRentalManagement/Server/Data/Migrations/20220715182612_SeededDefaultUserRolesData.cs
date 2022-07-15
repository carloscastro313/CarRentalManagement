using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultUserRolesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b416",
                column: "ConcurrencyStamp",
                value: "4105d050-86b2-4881-a3f4-6a5898a9213f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b417",
                column: "ConcurrencyStamp",
                value: "3e18a457-7f74-4a2a-9d7b-a23fe056287b");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c029105b-76dc-485d-9975-2029cf13b417", "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2" },
                    { "c029105b-76dc-485d-9975-2029cf13b416", "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc8b2751-c207-449c-85f7-ee8d18150457", "AQAAAAEAACcQAAAAEDgMcRWCqUjRU5wlE6RZkKnYbI0VSAQy2XK5iAyw8YyN6cXjNvJlaw9jRo+HIocMUg==", "96678423-d593-459f-820a-7441ab55ddc4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4be7b22-b4fa-4e55-8f2c-98d20a3c4162", "AQAAAAEAACcQAAAAEPeczQlSMrAlEyinKZLCi11x0JO0LDm64rfTfRT32B4JnFmKfyR5x8zl5OVN2AYxpg==", "060e0cd0-5b8e-4f55-be88-46bac91035e8" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9136), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9151), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9151) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9153), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9153) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9154), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9330), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9335), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9337), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9419), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9422), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9422) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9424), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9426), new DateTime(2022, 7, 15, 15, 26, 11, 705, DateTimeKind.Local).AddTicks(9426) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c029105b-76dc-485d-9975-2029cf13b417", "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c029105b-76dc-485d-9975-2029cf13b416", "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b416",
                column: "ConcurrencyStamp",
                value: "40c51ff9-b743-441c-ad20-205a7f14bef2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b417",
                column: "ConcurrencyStamp",
                value: "37dfda91-c089-4f3d-a241-e3efcdd3f5e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ad8d2b6-fc02-485c-8b37-4690234ee407", "AQAAAAEAACcQAAAAEFA0lUeU2CFp2JAqwtRQGFmJQcI8lopBj8/ffbs9iKoOdwPwgU2vdLMktizugB5yrA==", "37eb7e48-ce46-46b7-837b-84e355d32d9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02d35d59-67fd-48b1-a9f0-7f1ab1477587", "AQAAAAEAACcQAAAAEEO4bu5nYXSdXsb8Tqe+q3WyeB25i/l+nAIobbKYz364m0UjrVPtw2+rfNQsi3sBlA==", "bac553df-42f9-45e7-be3b-ba3eefce45a2" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7393), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7404), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7406), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7408), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7597), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7602), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7604), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7695), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7697), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7698), new DateTime(2022, 7, 15, 15, 17, 18, 261, DateTimeKind.Local).AddTicks(7699) });
        }
    }
}
