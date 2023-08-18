class Service {
  final String title;
  final String desc;
  final String image;

  Service({
    required this.title,
    required this.desc,
    required this.image,
  });

  factory Service.fromJson(Map<String, dynamic> json) {
    return Service(
      title: json["title"],
      desc: json["descritption"],
      image: json["picture"],
    );
  }
}
