class Activity {
  String date;
  int numberOfReservation;

  Activity({
    required this.date,
    required this.numberOfReservation,
  });

  factory Activity.fromJson(Map<String, dynamic> json) {
    return Activity(
      date: (json['date'] as String)
          .replaceAll('{ Date =', '')
          .replaceAll('}', ''),
      numberOfReservation: json['numberOfReservation'],
    );
  }
}
