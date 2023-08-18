class Feedback {
  int accountId;
  int feedbackId;
  int employees;
  int equipment;
  int serviceQuality;
  String comment;
  String username;

  Feedback({
    required this.accountId,
    required this.feedbackId,
    required this.employees,
    required this.equipment,
    required this.serviceQuality,
    required this.comment,
    required this.username,
  });

  factory Feedback.fromJson(Map<String, dynamic> json) {
    return Feedback(
      accountId: json['accountId'],
      feedbackId: json['feedbackId'],
      employees: json['employees'],
      equipment: json['equipment'],
      serviceQuality: json['serviceQuality'],
      comment: json['comment'],
      username: json['username'],
    );
  }
}
