using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eGym.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "AccountId", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9194), "lejla@husrep.com", "Lejla", 1, "Husrep", "lejlah123", 2, "lejlah" },
                    { 3, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9196), "dino@pelic.com", "Dino", 0, "Pelic", "dinop123", 2, "dinop" },
                    { 4, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9198), "amar@sehic.com", "Amar", 0, "Sehic", "amars123", 2, "amars" },
                    { 5, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9201), "hana@babic.com", "Hana", 1, "Babic", "hanab123", 2, "hanab" },
                    { 6, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9203), "faris@kovacevic.com", "Faris", 0, "Kovacevic", "farisk123", 2, "farisk" },
                    { 7, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9231), "arnesa@letica.com", "Arnesa", 1, "Letica", "arnesal123", 2, "arnesal" },
                    { 8, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9235), "envera@dedic.com", "Envera", 1, "Dedic", "enverad123", 2, "enverad" },
                    { 9, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9236), "edis@zebic.com", "Edis", 0, "Zebic", "edisz123", 2, "edisz" },
                    { 10, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9238), "dino@buric.com", "Dino", 1, "Buric", "dinob123", 2, "dinob" }
                });

            migrationBuilder.InsertData(
                table: "Diet",
                columns: new[] { "DietId", "AccountId", "Day", "Description", "Meal" },
                values: new object[,]
                {
                    { 1, 1, 1, "Eggs and dairy", 1 },
                    { 2, 1, 2, "Grilled chicken and salad", 2 },
                    { 3, 1, 0, "Protein shake", 0 }
                });

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

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "BirthDate", "Email", "FirstName", "Gender", "LastName", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9373), "nejla@hindic.com", "Nejla", 1, "Hindic", "nejla123", 1, "nejlah" },
                    { 5, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9375), "daris@hindic.com", "Daris", 0, "Hindic", "daris123", 1, "darish" },
                    { 6, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9377), "edi@muratovic.com", "Edi", 0, "Muratovic", "edi123", 0, "edim" },
                    { 7, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9382), "emira@cilic.com", "Emira", 1, "Cilic", "emira123", 0, "emiram" },
                    { 8, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9384), "edin@mesic.com", "Edin", 0, "Mesic", "edin123", 0, "edin" },
                    { 9, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9386), "amina@selimovic.com", "Amina", 1, "Selimovic", "amina123", 1, "aminas" },
                    { 10, new DateTime(2023, 5, 14, 16, 52, 54, 301, DateTimeKind.Local).AddTicks(9388), "sara@zukic.com", "Sara", 1, "Zukic", "sara123", 1, "saraz" }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "AccountId", "Comment", "Employees", "Equipment", "ServiceQuality" },
                values: new object[] { 1, 1, "Amazing personal trainers and complete, clean gym.", 1, 5, 0 });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationId", "AccountId", "Description", "EmployeeId", "From", "ReservationType", "Status", "To" },
                values: new object[] { 1, 1, "I would like to do weight training.", 3, new DateTime(2023, 5, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, new DateTime(2023, 5, 9, 13, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "ServiceId", "Descritption", "Picture", "Title" },
                values: new object[,]
                {
                    { 1, "We make sure that we have all the equipment necessary for a fantastic workout no matter what your style may be.", "https://media-cdn.tripadvisor.com/media/photo-s/1a/03/58/f5/hotel-gym-fully-equipped.jpg", "Top of the line equipment" },
                    { 2, "Whether you are a seasoned spinner, an avid road biker or just eager to test out a class for the first time, spinning has you covered.", "https://media1.popsugar-assets.com/files/thumbor/qSZhRw034Sm7XOwQxoPl9fF8AWY/fit-in/2048xorig/filters:format_auto-!!-:strip_icc-!!-/2016/07/05/076/n/1922729/917070f5052411b5_CyclingRendering_2048x1000.jpg", "Spinning studio" },
                    { 3, "Zumba is a dance based workout.", "https://thebridge.in/wp-content/uploads/2020/07/Untitled-design-16.jpg", "Zumba aerobics" },
                    { 4, "Functional training has become one of the trendiest most effective workouts possible.", "https://www.fitness-world.in/wp-content/uploads/2019/02/5-Steps-to-Create-a-Functional-Training-Space-for-Your-Commercial-Gym.jpg", "Functional training area" },
                    { 5, "Functional training has become one of the trendiest most effective workouts possible.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQwG8rLtLoDGo-Pz90RVmjVKCWAonfquCQAQ&usqp=CAU", "Plyometric boxes" },
                    { 6, "We have a special section reserved and accessed by only women.", "https://media.self.com/photos/59a5e9e3912f8b75cea00743/4:3/w_2560%2Cc_limit/GettyImages-583690235.jpg", "Women's only studio" },
                    { 7, "This luxury amenity is very popular amongst our clients.", "https://eliteclubs.com/wp-content/uploads/2019/11/Locker-Room-Dry-Cedar-Sauna-e1569515106806.jpg", "Steam and sauna rooms" },
                    { 8, "Yoga practice is a great way to strengthen the bond between your mind and your body.", "https://fitnessandwellnessnews.com/wp-content/uploads/2016/07/Yoga-class-stretch-pic.jpg", "Yoga classes" },
                    { 9, "We have group fitness classes all week long and throughout the day.", "https://www.ideafit.com/wp-content/uploads/files/Fitness%20Class%20Participation.jpg", "Aerobics classes" },
                    { 10, "Our personal trainers are here to help all members seeking to make the most out of their workouts. ", "https://content.active.com/Assets/Active.com+Content+Site+Digital+Assets/Fitness/Articles/Personal+Trainer/personal+trainer-carousel.jpg", "Personal training" }
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "TrainingId", "AccountId", "Day", "Description" },
                values: new object[,]
                {
                    { 1, 1, 0, "Barbell bench press, 5 sets, 12 reps" },
                    { 2, 1, 2, "Dumbbell shoulder press, 5 sets, 10 reps" }
                });

            migrationBuilder.InsertData(
                table: "Diet",
                columns: new[] { "DietId", "AccountId", "Day", "Description", "Meal" },
                values: new object[,]
                {
                    { 4, 3, 2, "Grilled chicken and salad", 2 },
                    { 5, 3, 5, "Protein shake", 0 },
                    { 6, 5, 2, "Grilled chicken and salad", 2 },
                    { 7, 7, 4, "Pasta with chicken and green salad", 2 },
                    { 8, 8, 2, "Eggs and dairy", 1 },
                    { 9, 8, 3, "Pasta with chicken and green salad", 2 },
                    { 10, 8, 6, "Protein shake", 0 }
                });

            migrationBuilder.InsertData(
                table: "Feedback",
                columns: new[] { "FeedbackId", "AccountId", "Comment", "Employees", "Equipment", "ServiceQuality" },
                values: new object[,]
                {
                    { 2, 2, "Very friendly team who make me actually want to go train.", 2, 5, 0 },
                    { 3, 3, "This is the worst fitness class I have ever attended.", 4, 1, 0 },
                    { 4, 5, "Excellent personal training.", 5, 5, 0 },
                    { 5, 4, "I had a bad experience with them. Not motivating at all.", 6, 1, 0 },
                    { 6, 3, "Amazing personal trainers and complete, clean gym.", 7, 5, 0 },
                    { 7, 7, "Excellent personal training.", 7, 5, 0 },
                    { 8, 8, "The gym is very modern and clean.", 3, 4, 0 },
                    { 9, 8, "This is the worst fitness class I have ever attended.", 8, 2, 0 },
                    { 10, 9, "The instructor doesn’t seem very prepared for class.", 9, 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationId", "AccountId", "Description", "EmployeeId", "From", "ReservationType", "Status", "To" },
                values: new object[,]
                {
                    { 2, 2, "I would like to do cardio.", 5, new DateTime(2023, 5, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2023, 5, 9, 15, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "Another description.", 4, new DateTime(2023, 5, 9, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, new DateTime(2023, 5, 9, 17, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 1, "I would like to do strength training.", 5, new DateTime(2023, 5, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 0, 3, new DateTime(2023, 5, 10, 13, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 4, "I want to dedicate more to this training.", 9, new DateTime(2023, 5, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, new DateTime(2023, 5, 10, 18, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, "Some description.", 7, new DateTime(2023, 5, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 2, 2, new DateTime(2023, 5, 10, 20, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, "I would like to do full-body workouts. ", 10, new DateTime(2023, 5, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2023, 5, 11, 14, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, "I would like to do pilates training.", 9, new DateTime(2023, 5, 12, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, new DateTime(2023, 5, 12, 17, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 7, "I would like to do balance and stability training.", 6, new DateTime(2023, 5, 12, 20, 0, 0, 0, DateTimeKind.Unspecified), 3, 3, new DateTime(2023, 5, 12, 21, 15, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 5, "I would like to do flexibility and mobility Training.", 1, new DateTime(2023, 5, 13, 13, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, new DateTime(2023, 5, 13, 14, 15, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "TrainingId", "AccountId", "Day", "Description" },
                values: new object[,]
                {
                    { 4, 3, 3, "Floor press, 4 sets, 10 reps " },
                    { 5, 3, 5, "Flexibility and stretching" },
                    { 6, 5, 3, "Hammer Curls, 5 sets, 8 reps" },
                    { 7, 7, 5, "Incline bench press, 3 sets, 12 reps" },
                    { 8, 8, 1, "Close grip lat pulldown, 3 sets, 10 reps" },
                    { 9, 8, 6, "Leg raises, 3 sets, 10 reps" },
                    { 10, 8, 2, "Seated rows, 4 sets, 10 reps" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Diet",
                keyColumn: "DietId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Feedback",
                keyColumn: "FeedbackId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "ServiceId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Training",
                keyColumn: "TrainingId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "AccountId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "EmployeeId",
                keyValue: 10);

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
    }
}
