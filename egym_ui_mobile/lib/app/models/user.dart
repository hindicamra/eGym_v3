import 'package:egym_ui_mobile/app/modules/registration/controllers/registration_controller.dart';

enum UserRole { admin, employee, user }

class User {
  int id;
  String firstName;
  String lastName;
  String username;
  String? email;
  UserRole role;
  Spol gender;
  DateTime birthDate;

  User({
    required this.id,
    required this.firstName,
    required this.lastName,
    required this.username,
    required this.email,
    required this.role,
    required this.gender,
    required this.birthDate,
  });

  factory User.fromJson(Map<String, dynamic> json) {
    return User(
      id: json['accountId'] ?? json['employeeId'],
      firstName: json['firstName'],
      lastName: json['lastName'],
      username: json['username'],
      email: json['email'],
      role: json['role'] == 0
          ? UserRole.admin
          : json['role'] == 1
              ? UserRole.employee
              : UserRole.user,
      gender: json['gender'] == 0 ? Spol.musko : Spol.zensko,
      birthDate: DateTime.parse(json['birthDate']),
    );
  }
}
