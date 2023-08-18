import 'dart:io';

import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:egym_ui_mobile/app/routes/app_pages.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';

import 'package:get/get.dart';

import '../../../styles/text_field_decoration.dart';
import '../controllers/login_controller.dart';

class LoginView extends GetView<LoginController> {
  const LoginView({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: SizedBox(
          height: Get.height,
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 25),
            child: Form(
              key: controller.loginFormKey,
              child: Column(
                children: [
                  const Spacer(flex: 3),
                  const Text(
                    'Dobro došli',
                    style: TextStyle(fontSize: 24),
                  ),
                  const Spacer(flex: 3),
                  SvgPicture.asset(
                    'assets/images/ilustration1.svg',
                    width: Platform.isWindows
                        ? Get.size.height * .3
                        : Get.size.width * .6,
                  ),
                  const Spacer(flex: 3),
                  const Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      'Korisničko ime\n',
                      style: TextStyle(
                        color: AppColors.orange,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                  TextFormField(
                    decoration: appTextFieldDecoration(
                      hintText: 'Korisničko ime',
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Polje je obavezno';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      controller.username = value!;
                    },
                  ),
                  const SizedBox(height: 15),
                  const Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      'Lozinka\n',
                      style: TextStyle(
                        color: AppColors.orange,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                  TextFormField(
                    decoration: appTextFieldDecoration(
                      hintText: 'Pass123',
                    ),
                    validator: (value) {
                      if (value == null || value.isEmpty) {
                        return 'Polje je obavezno';
                      }
                      return null;
                    },
                    onSaved: (value) {
                      controller.password = value!;
                    },
                  ),
                  const Spacer(),
                  SizedBox(
                    width: double.infinity,
                    child: ElevatedButton(
                      style: ButtonStyle(
                        backgroundColor:
                            MaterialStateProperty.all(AppColors.orange),
                      ),
                      child: const Text('Prijava'),
                      onPressed: () => controller.onPressLogin(),
                    ),
                  ),
                  SizedBox(
                    width: double.infinity,
                    child: TextButton(
                      child: const Text(
                        'Registruj se',
                        style: TextStyle(
                          color: AppColors.darkGreyText,
                        ),
                      ),
                      onPressed: () {
                        Get.find<ApiService>().basicAuth = null;
                        Get.toNamed(Routes.REGISTRATION);
                      },
                    ),
                  ),
                  const Spacer(),
                ],
              ),
            ),
          ),
        ),
      ),
    );
  }
}
