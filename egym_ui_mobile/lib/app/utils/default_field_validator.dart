String? defaultFieldValidator(String? value) {
  if (value == null || value.isEmpty) {
    return 'Polje je obavezno';
  }
  if (value.length < 3) {
    return 'Minimalno 3 karaktera';
  }
  return null;
}
