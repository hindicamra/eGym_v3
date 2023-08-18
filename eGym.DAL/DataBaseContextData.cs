using eGym.Domain;
using Microsoft.EntityFrameworkCore;

namespace eGym.DAL;

public partial class DataBaseContext
{
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>().HasData(
            new Account() { AccountId = 1, Username = "user", FirstName = "user", Password = "test", BirthDate = DateTime.Now, LastName = "user", Email = "user@test.com", Gender = 1, Role = 2 },
            new Account() { AccountId = 2, Username = "lejlah", FirstName = "Lejla", Password = "lejlah123", BirthDate = DateTime.Now, LastName = "Husrep", Email = "lejla@husrep.com", Gender = 1, Role = 2 },
            new Account() { AccountId = 3, Username = "dinop", FirstName = "Dino", Password = "dinop123", BirthDate = DateTime.Now, LastName = "Pelic", Email = "dino@pelic.com", Gender = 0, Role = 2 },
            new Account() { AccountId = 4, Username = "amars", FirstName = "Amar", Password = "amars123", BirthDate = DateTime.Now, LastName = "Sehic", Email = "amar@sehic.com", Gender = 0, Role = 2 },
            new Account() { AccountId = 5, Username = "hanab", FirstName = "Hana", Password = "hanab123", BirthDate = DateTime.Now, LastName = "Babic", Email = "hana@babic.com", Gender = 1, Role = 2 },
            new Account() { AccountId = 6, Username = "farisk", FirstName = "Faris", Password = "farisk123", BirthDate = DateTime.Now, LastName = "Kovacevic", Email = "faris@kovacevic.com", Gender = 0, Role = 2 },
            new Account() { AccountId = 7, Username = "arnesal", FirstName = "Arnesa", Password = "arnesal123", BirthDate = DateTime.Now, LastName = "Letica", Email = "arnesa@letica.com", Gender = 1, Role = 2 },
            new Account() { AccountId = 8, Username = "enverad", FirstName = "Envera", Password = "enverad123", BirthDate = DateTime.Now, LastName = "Dedic", Email = "envera@dedic.com", Gender = 1, Role = 2 },
            new Account() { AccountId = 9, Username = "edisz", FirstName = "Edis", Password = "edisz123", BirthDate = DateTime.Now, LastName = "Zebic", Email = "edis@zebic.com", Gender = 0, Role = 2 },
            new Account() { AccountId = 10, Username = "dinob", FirstName = "Dino", Password = "dinob123", BirthDate = DateTime.Now, LastName = "Buric", Email = "dino@buric.com", Gender = 1, Role = 2 }
            );

        modelBuilder.Entity<Employee>().HasData(
            new Employee() { EmployeeId = 1, Username = "desktop", FirstName = "desktop", Password = "test", BirthDate = DateTime.Now, LastName = "desktop", Email = "desktop@test.com", Gender = 1, Role = 0 },
            new Employee() { EmployeeId = 2, Username = "mobile", FirstName = "mobile", Password = "test", BirthDate = DateTime.Now, LastName = "mobile", Email = "mobile@test.com", Gender = 1, Role = 0 },
            new Employee() { EmployeeId = 3, Username = "employee", FirstName = "employee", Password = "test", BirthDate = DateTime.Now, LastName = "employee", Email = "employee@test.com", Gender = 1, Role = 1 },
            new Employee() { EmployeeId = 4, Username = "nejlah", FirstName = "Nejla", Password = "nejla123", BirthDate = DateTime.Now, LastName = "Hindic", Email = "nejla@hindic.com", Gender = 1, Role = 1 },
            new Employee() { EmployeeId = 5, Username = "darish", FirstName = "Daris", Password = "daris123", BirthDate = DateTime.Now, LastName = "Hindic", Email = "daris@hindic.com", Gender = 0, Role = 1 },
            new Employee() { EmployeeId = 6, Username = "edim", FirstName = "Edi", Password = "edi123", BirthDate = DateTime.Now, LastName = "Muratovic", Email = "edi@muratovic.com", Gender = 0, Role = 0 },
            new Employee() { EmployeeId = 7, Username = "emiram", FirstName = "Emira", Password = "emira123", BirthDate = DateTime.Now, LastName = "Cilic", Email = "emira@cilic.com", Gender = 1, Role = 0 },
            new Employee() { EmployeeId = 8, Username = "edin", FirstName = "Edin", Password = "edin123", BirthDate = DateTime.Now, LastName = "Mesic", Email = "edin@mesic.com", Gender = 0, Role = 0 },
            new Employee() { EmployeeId = 9, Username = "aminas", FirstName = "Amina", Password = "amina123", BirthDate = DateTime.Now, LastName = "Selimovic", Email = "amina@selimovic.com", Gender = 1, Role = 1 },
            new Employee() { EmployeeId = 10, Username = "saraz", FirstName = "Sara", Password = "sara123", BirthDate = DateTime.Now, LastName = "Zukic", Email = "sara@zukic.com", Gender = 1, Role = 1 }
           );

        modelBuilder.Entity<Service>().HasData(
            new Service() { ServiceId = 1, Title = "Top of the line equipment", Descritption = "We make sure that we have all the equipment necessary for a fantastic workout no matter what your style may be.", Picture = "https://media-cdn.tripadvisor.com/media/photo-s/1a/03/58/f5/hotel-gym-fully-equipped.jpg" },
            new Service() { ServiceId = 2, Title = "Spinning studio", Descritption = "Whether you are a seasoned spinner, an avid road biker or just eager to test out a class for the first time, spinning has you covered.", Picture = "https://media1.popsugar-assets.com/files/thumbor/qSZhRw034Sm7XOwQxoPl9fF8AWY/fit-in/2048xorig/filters:format_auto-!!-:strip_icc-!!-/2016/07/05/076/n/1922729/917070f5052411b5_CyclingRendering_2048x1000.jpg" },
            new Service() { ServiceId = 3, Title = "Zumba aerobics", Descritption = "Zumba is a dance based workout.", Picture = "https://thebridge.in/wp-content/uploads/2020/07/Untitled-design-16.jpg" },
            new Service() { ServiceId = 4, Title = "Functional training area", Descritption = "Functional training has become one of the trendiest most effective workouts possible.", Picture = "https://www.fitness-world.in/wp-content/uploads/2019/02/5-Steps-to-Create-a-Functional-Training-Space-for-Your-Commercial-Gym.jpg" },
            new Service() { ServiceId = 5, Title = "Plyometric boxes", Descritption = "Functional training has become one of the trendiest most effective workouts possible.", Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRQwG8rLtLoDGo-Pz90RVmjVKCWAonfquCQAQ&usqp=CAU" },
            new Service() { ServiceId = 6, Title = "Women's only studio", Descritption = "We have a special section reserved and accessed by only women.", Picture = "https://media.self.com/photos/59a5e9e3912f8b75cea00743/4:3/w_2560%2Cc_limit/GettyImages-583690235.jpg" },
            new Service() { ServiceId = 7, Title = "Steam and sauna rooms", Descritption = "This luxury amenity is very popular amongst our clients.", Picture = "https://eliteclubs.com/wp-content/uploads/2019/11/Locker-Room-Dry-Cedar-Sauna-e1569515106806.jpg" },
            new Service() { ServiceId = 8, Title = "Yoga classes", Descritption = "Yoga practice is a great way to strengthen the bond between your mind and your body.", Picture = "https://fitnessandwellnessnews.com/wp-content/uploads/2016/07/Yoga-class-stretch-pic.jpg" },
            new Service() { ServiceId = 9, Title = "Aerobics classes", Descritption = "We have group fitness classes all week long and throughout the day.", Picture = "https://www.ideafit.com/wp-content/uploads/files/Fitness%20Class%20Participation.jpg" },
            new Service() { ServiceId = 10, Title = "Personal training", Descritption = "Our personal trainers are here to help all members seeking to make the most out of their workouts. ", Picture = "https://content.active.com/Assets/Active.com+Content+Site+Digital+Assets/Fitness/Articles/Personal+Trainer/personal+trainer-carousel.jpg" }
            );

        modelBuilder.Entity<Diet>().HasData(
         new Diet() { DietId = 1, Day = 1, Meal = 1, Description = "Eggs and dairy", AccountId = 1 },
         new Diet() { DietId = 2, Day = 2, Meal = 2, Description = "Grilled chicken and salad", AccountId = 1 },
         new Diet() { DietId = 3, Day = 5, Meal = 0, Description = "Protein shake", AccountId = 1 },
         new Diet() { DietId = 4, Day = 3, Meal = 2, Description = "Grilled chicken and salad", AccountId = 3 },
         new Diet() { DietId = 5, Day = 0, Meal = 0, Description = "Protein shake", AccountId = 3 },
         new Diet() { DietId = 6, Day = 1, Meal = 2, Description = "Grilled chicken and salad", AccountId = 5 },
         new Diet() { DietId = 7, Day = 4, Meal = 2, Description = "Pasta with chicken and green salad", AccountId = 7 },
         new Diet() { DietId = 8, Day = 2, Meal = 1, Description = "Eggs and dairy", AccountId = 8 },
         new Diet() { DietId = 9, Day = 3, Meal = 2, Description = "Pasta with chicken and green salad", AccountId = 8 },
         new Diet() { DietId = 10, Day = 6, Meal = 0, Description = "Protein shake", AccountId = 8 }
         );

        modelBuilder.Entity<Feedback>().HasData(
           new Feedback() { FeedbackId = 1, Employees = 1, Equipment = 5, Comment = "Amazing personal trainers and complete, clean gym.", AccountId = 1 },
           new Feedback() { FeedbackId = 2, Employees = 2, Equipment = 5, Comment = "Very friendly team who make me actually want to go train.", AccountId = 2 },
           new Feedback() { FeedbackId = 3, Employees = 4, Equipment = 1, Comment = "This is the worst fitness class I have ever attended.", AccountId = 3 },
           new Feedback() { FeedbackId = 4, Employees = 5, Equipment = 5, Comment = "Excellent personal training.", AccountId = 5 },
           new Feedback() { FeedbackId = 5, Employees = 6, Equipment = 1, Comment = "I had a bad experience with them. Not motivating at all.", AccountId = 4 },
           new Feedback() { FeedbackId = 6, Employees = 7, Equipment = 5, Comment = "Amazing personal trainers and complete, clean gym.", AccountId = 3 },
           new Feedback() { FeedbackId = 7, Employees = 7, Equipment = 5, Comment = "Excellent personal training.", AccountId = 7 },
           new Feedback() { FeedbackId = 8, Employees = 3, Equipment = 4, Comment = "The gym is very modern and clean.", AccountId = 8 },
           new Feedback() { FeedbackId = 9, Employees = 8, Equipment = 2, Comment = "This is the worst fitness class I have ever attended.", AccountId = 8 },
           new Feedback() { FeedbackId = 10, Employees = 9, Equipment = 2, Comment = "The instructor doesn’t seem very prepared for class.", AccountId = 9 }
           );

        modelBuilder.Entity<Training>().HasData(
         new Training() { TrainingId = 1, Day = 0, Description = "Barbell bench press, 5 sets, 12 reps", AccountId = 1 },
         new Training() { TrainingId = 2, Day = 2, Description = "Dumbbell shoulder press, 5 sets, 10 reps", AccountId = 1 },
         new Training() { TrainingId = 4, Day = 3, Description = "Floor press, 4 sets, 10 reps ", AccountId = 3 },
         new Training() { TrainingId = 5, Day = 5, Description = "Flexibility and stretching", AccountId = 3 },
         new Training() { TrainingId = 6, Day = 3, Description = "Hammer Curls, 5 sets, 8 reps", AccountId = 5 },
         new Training() { TrainingId = 7, Day = 5, Description = "Incline bench press, 3 sets, 12 reps", AccountId = 7 },
         new Training() { TrainingId = 8, Day = 1, Description = "Close grip lat pulldown, 3 sets, 10 reps", AccountId = 8 },
         new Training() { TrainingId = 9, Day = 6, Description = "Leg raises, 3 sets, 10 reps", AccountId = 8 },
         new Training() { TrainingId = 10, Day = 2, Description = "Seated rows, 4 sets, 10 reps", AccountId = 8 }
            );

        modelBuilder.Entity<Reservation>().HasData(
        new Reservation() { ReservationId = 1, From = new DateTime(2023, 05, 09, 12, 00, 00), To = new DateTime(2023, 05, 09, 13, 15, 00), Description = "I would like to do weight training.", Status = 1, AccountId = 1, EmployeeId = 3, ReservationType = 0 },
        new Reservation() { ReservationId = 2, From = new DateTime(2023, 05, 09, 14, 00, 00), To = new DateTime(2023, 05, 09, 15, 30, 00), Description = "I would like to do cardio.", Status = 2, AccountId = 2, EmployeeId = 5, ReservationType = 1 },
        new Reservation() { ReservationId = 3, From = new DateTime(2023, 05, 09, 16, 00, 00), To = new DateTime(2023, 05, 09, 17, 15, 00), Description = "Another description.", Status = 2, AccountId = 3, EmployeeId = 4, ReservationType = 3 },
        new Reservation() { ReservationId = 4, From = new DateTime(2023, 05, 10, 12, 00, 00), To = new DateTime(2023, 05, 10, 13, 15, 00), Description = "I would like to do strength training.", Status = 3, AccountId = 1, EmployeeId = 5, ReservationType = 0 },
        new Reservation() { ReservationId = 5, From = new DateTime(2023, 05, 10, 18, 00, 00), To = new DateTime(2023, 05, 10, 18, 15, 00), Description = "I want to dedicate more to this training.", Status = 4, AccountId = 4, EmployeeId = 9, ReservationType = 1 },
        new Reservation() { ReservationId = 6, From = new DateTime(2023, 05, 10, 19, 00, 00), To = new DateTime(2023, 05, 10, 20, 15, 00), Description = "Some description.", Status = 2, AccountId = 6, EmployeeId = 7, ReservationType = 2 },
        new Reservation() { ReservationId = 7, From = new DateTime(2023, 05, 11, 13, 00, 00), To = new DateTime(2023, 05, 11, 14, 15, 00), Description = "I would like to do full-body workouts. ", Status = 1, AccountId = 3, EmployeeId = 10, ReservationType = 1 },
        new Reservation() { ReservationId = 8, From = new DateTime(2023, 05, 12, 16, 00, 00), To = new DateTime(2023, 05, 12, 17, 15, 00), Description = "I would like to do pilates training.", Status = 4, AccountId = 8, EmployeeId = 9, ReservationType = 3 },
        new Reservation() { ReservationId = 9, From = new DateTime(2023, 05, 12, 20, 00, 00), To = new DateTime(2023, 05, 12, 21, 15, 00), Description = "I would like to do balance and stability training.", Status = 3, AccountId = 7, EmployeeId = 6, ReservationType = 3 },
        new Reservation() { ReservationId = 10, From = new DateTime(2023, 05, 13, 13, 00, 00), To = new DateTime(2023, 05, 13, 14, 15, 00), Description = "I would like to do flexibility and mobility Training.", Status = 3, AccountId = 5, EmployeeId = 1, ReservationType = 2 }
       );

    }
}