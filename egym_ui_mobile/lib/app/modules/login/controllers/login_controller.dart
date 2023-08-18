import 'package:egym_ui_mobile/app/controllers/user_controller.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:egym_ui_mobile/app/models/user.dart';
import 'package:egym_ui_mobile/app/routes/app_pages.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class LoginController extends GetxController {
  final _userController = Get.find<UserController>();
  final _api = Get.find<ApiService>();

  final loginFormKey = GlobalKey<FormState>();
  String username = '';
  String password = '';

  void onPressLogin() async {
    final isValid = loginFormKey.currentState!.validate();
    if (!isValid) return;

    loginFormKey.currentState!.save();
    _api.generateBasicAuth(username, password);

    final response = await _api.post('/Account/login', {}, query: {
      "username": username,
      "password": password,
    });

    if (response.isOk) {
      final user = User.fromJson(response.body);
      _userController.setUser(user);

      Get.offAllNamed(Routes.HOME);
    } else {
      Get.snackbar(
        'Problem',
        'Molimo provjerite podatke za prijavu i pokušajte ponovo',
      );
    }
  }
}
