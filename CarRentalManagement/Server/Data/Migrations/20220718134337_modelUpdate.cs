using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class modelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b416",
                column: "ConcurrencyStamp",
                value: "c6cb2d25-330b-4e21-b9d3-b44670e61735");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c029105b-76dc-485d-9975-2029cf13b417",
                column: "ConcurrencyStamp",
                value: "9d314f8a-5b6a-4ee6-bb7a-5c6a852ee337");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "260642a5-6279-4171-b2aa-3f493cdc66d5", "AQAAAAEAACcQAAAAEI8kaQ6CtTVxN5CgQ+59luCFTumsYsT4DMmN5toahepPzIuArAVBBJBzZRcocOMG2Q==", "ed52f4b1-5723-468c-8e33-70f142174485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "183d60c9-9546-4a79-8e20-b8726918967e", "AQAAAAEAACcQAAAAEKpkQ9pVAUS/dE8OoykS6lTTJcdHb/EyOeQWOeH3w/XkMRqLMj36BdpJEvkRJVPcGQ==", "06d37f8d-d096-4a17-b34d-11990c60adb7" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5251), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5262), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5264), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5266), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5435), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5437), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5439), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5441), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5441) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5518), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5522), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5523) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5524), new DateTime(2022, 7, 18, 10, 43, 36, 809, DateTimeKind.Local).AddTicks(5525) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
