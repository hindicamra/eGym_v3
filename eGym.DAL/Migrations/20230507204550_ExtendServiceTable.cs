using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGym.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ExtendServiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 22, 45, 50, 748, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 22, 45, 50, 748, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 22, 45, 50, 748, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 5, 7, 22, 45, 50, 748, DateTimeKind.Local).AddTicks(6380));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Service");

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
