using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGym.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ResrvationTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationType",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9090), "user@test.com" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9220), "desktop@test.com" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9230), "mobile@test.com" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9230), "employee@test.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationType",
                table: "Reservation");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9500), null });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9640), null });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9650), null });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "BirthDate", "Email" },
                values: new object[] { new DateTime(2023, 5, 6, 10, 33, 46, 691, DateTimeKind.Local).AddTicks(9650), null });
        }
    }
}
