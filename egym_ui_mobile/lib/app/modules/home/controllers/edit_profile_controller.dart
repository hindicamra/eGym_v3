import 'package:egym_ui_mobile/app/models/user.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../../../controllers/user_controller.dart';
import '../../../services/api_service.dart';

class EditProfileController extends GetxController {
  static final userController = Get.find<UserController>();
  static final user = userController.user.value!;
  final _api = Get.find<ApiService>();

  final registrationFormKey = GlobalKey<FormState>();

  Rx<DateTime> birthDay = Rx(user.birthDate);
  String name = user.firstName;
  String surname = user.lastName;
  String nickname = user.username;
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

  void onPressUpdate() async {
    final isValid = registrationFormKey.currentState!.validate();
    if (!isValid) return;

    registrationFormKey.currentState!.save();

    final response = await _api.put(
      '/Account',
      {
        "firstName": name,
        "lastName": surname,
        "username": nickname,
        if (password.isNotEmpty) "password": password,
        "birthDate": birthDay.value.toIso8601String(),
      },
      query: {
        "id": user.id.toString(),
      },
    );

    if (response.isOk) {
      userController.user.value = User(
        id: user.id,
        firstName: name,
        lastName: surname,
        username: nickname,
        email: user.email,
        role: user.role,
        gender: user.gender,
        birthDate: birthDay.value,
      );
      Get.snackbar(
        'Uspješno',
        'Uspješno ste izmjenili podatke profila.',
      );
    } else {
      Get.snackbar(
        'Problem',
        'Desio se problem. Molimo pokušajte ponovo.',
      );
    }
  }
}
