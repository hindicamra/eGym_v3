using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eGym.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddStripePaymentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StripePaymentId",
                table: "Payment",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 1,
                column: "Day",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 2,
                column: "Day",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 3,
                columns: new[] { "Day", "Meal" },
                values: new object[] { 5, 0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 4,
                column: "Day",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 5,
                columns: new[] { "Day", "Meal" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 6,
                column: "Day",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 7,
                column: "Day",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 8,
                column: "Day",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 9,
                column: "Day",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 10,
                columns: new[] { "Day", "Meal" },
                values: new object[] { 6, 0 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "BirthDate", "Role" },
                values: new object[] { new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8347), 0 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "BirthDate", "Role" },
                values: new object[] { new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8356), 0 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "BirthDate", "Role" },
                values: new object[] { new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8359), 1 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(2023, 9, 13, 12, 2, 37, 882, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "To",
                value: new DateTime(2023, 5, 10, 13, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "To",
                value: new DateTime(2023, 5, 10, 18, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "To",
                value: new DateTime(2023, 5, 10, 20, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 1,
                column: "Day",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 2,
                column: "Day",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 4,
                column: "Day",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 5,
                column: "Day",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 6,
                column: "Day",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 7,
                column: "Day",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 8,
                column: "Day",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 9,
                column: "Day",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 10,
                column: "Day",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StripePaymentId",
                table: "Payment");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 9,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 1,
                column: "Day",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 2,
                column: "Day",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 3,
                columns: new[] { "Day", "Meal" },
                values: new object[] { 40, 3 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 4,
                column: "Day",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 5,
                columns: new[] { "Day", "Meal" },
                values: new object[] { 36, 3 });

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 6,
                column: "Day",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 7,
                column: "Day",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 8,
                column: "Day",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 9,
                column: "Day",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 10,
                columns: new[] { "Day", "Meal" },
                values: new object[] { 31, 3 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9373));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6,
                columns: new[] { "BirthDate", "Role" },
                values: new object[] { new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9377), 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8,
                columns: new[] { "BirthDate", "Role" },
                values: new object[] { new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9384), 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9,
                columns: new[] { "BirthDate", "Role" },
                values: new object[] { new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9386), 2 });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "To",
                value: new DateTime(2023, 5, 9, 13, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "To",
                value: new DateTime(2023, 5, 9, 18, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "To",
                value: new DateTime(2023, 5, 9, 20, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 1,
                column: "Day",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 2,
                column: "Day",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 4,
                column: "Day",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 5,
                column: "Day",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 6,
                column: "Day",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 7,
                column: "Day",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 8,
                column: "Day",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 9,
                column: "Day",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 10,
                column: "Day",
                value: 31);
        }
    }
}
