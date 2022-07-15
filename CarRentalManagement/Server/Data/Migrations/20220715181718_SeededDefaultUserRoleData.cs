using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class SeededDefaultUserRoleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93405ef4-7a8e-4c96-8cb1-852a265dbb77", "AQAAAAEAACcQAAAAEJwD1nifXKxVqppVRT2GiyJiI0uL9RICeJgTecQJdu3OJ1/h8WvrVs0PdXxB74JGsw==", "96641ca7-a70a-4b97-a4bb-e2b33ed39121" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff2c1a74-6cdc-40e0-ae1f-2c5da4e8e9f3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b2a900-4f60-4296-819d-9db3e9a6b644", "AQAAAAEAACcQAAAAEP/NAallaUuIHgMDCxavBB8klVfojt8NZ4Ldf1ADrz/9yYzaBtUOJkZuMjG5Zf9QPA==", "18119e02-7bee-4782-bedc-cc09f17d8577" });

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
    }
}
