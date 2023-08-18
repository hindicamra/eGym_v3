import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

enum Spol {
  musko,
  zensko,
}

class RegistrationController extends GetxController {
  final _api = Get.find<ApiService>();

  final registrationFormKey = GlobalKey<FormState>();
  Rxn<Spol> spol = Rxn<Spol>();
  Rx<DateTime> birthDay = DateTime.now().obs;
  String email = '';
  String name = '';
  String surname = '';
  String nickname = '';
  String password = '';

  Future<void> selectBirthdayDate(BuildContext context) async {
    final newDate = await showDatePicker(
      context: context,
      initialDate: DateTime.now(),
      firstDate: DateTime.now().subtract(const Duration(days: 365 * 50)),
      lastDate: DateTime.now(),
    );

    if (newDate != null) {
      birthDay.value = newDate;
    }
  }

  void onPressRegister() async {
    final isValid = registrationFormKey.currentState!.validate();
    if (!isValid) return;
    if (spol.value == null) {
      Get.showSnackbar(const GetSnackBar(
        message: 'Molimo odaberite spol',
        backgroundColor: AppColors.error,
        snackPosition: SnackPosition.TOP,
        duration: Duration(seconds: 2),
      ));
      return;
    }

    registrationFormKey.currentState!.save();

    final response = await _api.post('/Account', {
      "firstName": name,
      "lastName": surname,
      "username": nickname,
      "password": password,
      "email": email,
      "gender": spol.value == Spol.musko ? 0 : 1,
      "birthDate": birthDay.value.toIso8601String(),
    });

    if (response.isOk) {
      Get.back();
      Get.snackbar(
        'Uspješno',
        'Uspješno ste se registrovali.',
      );
    } else {
      Get.snackbar(
        'Problem',
        'Desio se problem prilikom pokušaja registracije profila. Molimo pokušajte ponovo.',
      );
    }
  }
}
