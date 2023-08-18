import 'package:egym_ui_mobile/app/models/termin_type.dart';

class Termin {
  int reservationId;
  DateTime from;
  DateTime to;
  String description;
  int status;
  String reservationType;
  int accountId;
  int employeeId;
  String employeeName;

  Termin({
    required this.reservationId,
    required this.from,
    required this.to,
    required this.description,
    required this.status,
    required this.reservationType,
    required this.accountId,
    required this.employeeId,
    required this.employeeName,
  });

  factory Termin.fromJson(Map<String, dynamic> json) {
    return Termin(
      reservationId: json['reservationId'],
      from: DateTime.parse(json['from']),
      to: DateTime.parse(json['to']),
      description: json['description'],
      status: json['status'],
      reservationType: TerminType.trainingFromInt(json['reservationType'] ?? 0),
      accountId: json['accountId'],
      employeeId: json['employeeId'],
      employeeName: json['employeeName'],
    );
  }
}
