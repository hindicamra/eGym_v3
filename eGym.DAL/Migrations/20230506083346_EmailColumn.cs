using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGym.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EmailColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Account");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 2, 19, 19, 15, 964, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 2, 19, 19, 15, 964, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 5, 2, 19, 19, 15, 964, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 5, 2, 19, 19, 15, 964, DateTimeKind.Local).AddTicks(5178));
        }
    }
}
