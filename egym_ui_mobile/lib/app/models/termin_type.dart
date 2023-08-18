class TerminType {
  static List<String> trainings = [
    'Weightlifting',
    'Functional',
    'Aerobics',
    'Cardio',
  ];

  static int trainingToInt(String trainingType) {
    switch (trainingType) {
      case 'Weightlifting':
        return 0;
      case 'Functional':
        return 1;
      case 'Aerobics':
        return 2;
      case 'Cardio':
        return 3;
      default:
        return 0;
    }
  }

  static String trainingFromInt(int trainingType) {
    switch (trainingType) {
      case 0:
        return 'Weightlifting';
      case 1:
        return 'Functional';
      case 2:
        return 'Aerobics';
      case 3:
        return 'Cardio';
      default:
        return 'Weightlifting';
    }
  }
}
