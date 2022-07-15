using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2777), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2786), "Black", "System" },
                    { 2, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2788), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2789), "Blue", "System" },
                    { 3, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2791), "Red", "System" },
                    { 4, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2792), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(2793), "White", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3002), "Toyota", "System" },
                    { 2, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3004), "Fiat", "System" },
                    { 3, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3005), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3006), "Renault", "System" },
                    { 4, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3007), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3008), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3087), "Duster", "System" },
                    { 2, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3088), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3089), "Corolla", "System" },
                    { 3, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3091), "Uno", "System" },
                    { 4, "System", new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3092), new DateTime(2022, 7, 15, 11, 16, 1, 727, DateTimeKind.Local).AddTicks(3093), "X3", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
