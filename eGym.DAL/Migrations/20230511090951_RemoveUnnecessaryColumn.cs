using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGym.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnnecessaryColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Meal",
                table: "Training");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 11, 11, 9, 51, 651, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 11, 11, 9, 51, 651, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 5, 11, 11, 9, 51, 651, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 5, 11, 11, 9, 51, 651, DateTimeKind.Local).AddTicks(2892));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Meal",
                table: "Training",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 12, 45, 46, 344, DateTimeKind.Local).AddTicks(9230));
        }
    }
}
