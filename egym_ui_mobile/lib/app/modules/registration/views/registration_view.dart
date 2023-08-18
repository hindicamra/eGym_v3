import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/styles/text_field_decoration.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';
import 'package:intl/intl.dart';

import '../../../utils/default_field_validator.dart';
import '../controllers/registration_controller.dart';

class RegistrationView extends GetView<RegistrationController> {
  const RegistrationView({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: SizedBox(
          height: Get.height,
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 25),
            child: Obx(
              () => Form(
                key: controller.registrationFormKey,
                child: Column(
                  children: [
                    const Spacer(flex: 3),
                    const Text(
                      'Registruj se',
                      style: TextStyle(fontSize: 24),
                    ),
                    const Spacer(flex: 2),
                    TextFormField(
                      decoration: appTextFieldDecoration(
                        hintText: 'Ime',
                      ),
                      validator: defaultFieldValidator,
                      onSaved: (newValue) {
                        controller.name = newValue!;
                      },
                    ),
                    const SizedBox(height: 15),
                    TextFormField(
                      decoration: appTextFieldDecoration(
                        hintText: 'Prezime',
                      ),
                      validator: defaultFieldValidator,
                      onSaved: (newValue) {
                        controller.surname = newValue!;
                      },
                    ),
                    const SizedBox(height: 15),
                    TextFormField(
                      decoration: appTextFieldDecoration(
                        hintText: 'Email',
                      ),
                      validator: (value) {
                        if (value == null || value.isEmpty) {
                          return 'Polje je obavezno';
                        }
                        if (!value.contains('@') || !value.contains('.')) {
                          return 'Polje mora sadržati @ ili . znakove';
                        }
                        return null;
                      },
                      onSaved: (newValue) {
                        controller.email = newValue!;
                      },
                    ),
                    const SizedBox(height: 15),
                    TextFormField(
                      decoration: appTextFieldDecoration(
                        hintText: 'Korisničko ime',
                      ),
                      validator: defaultFieldValidator,
                      onSaved: (newValue) {
                        controller.nickname = newValue!;
                      },
                    ),
                    const SizedBox(height: 15),
                    TextFormField(
                      decoration: appTextFieldDecoration(
                        hintText: 'Lozinka',
                      ),
                      validator: defaultFieldValidator,
                      onSaved: (newValue) {
                        controller.password = newValue!;
                      },
                    ),
                    const SizedBox(height: 15),
                    const Align(
                      alignment: Alignment.centerLeft,
                      child: Text(
                        'Datum rođenja',
                      ),
                    ),
                    const SizedBox(height: 15),
                    GestureDetector(
                      onTap: () => controller.selectBirthdayDate(context),
                      child: Container(
                        height: 45,
                        width: double.infinity,
                        padding: const EdgeInsets.only(left: 10),
                        decoration: BoxDecoration(
                          color: AppColors.fieldColor,
                          borderRadius: BorderRadius.circular(10),
                        ),
                        child: Row(
                          children: [
                            Expanded(
                              child: Text(
                                DateFormat('dd/MM/yyyy')
                                    .format(controller.birthDay.value),
                              ),
                            ),
                            Container(
                              height: 45,
                              width: 45,
                              alignment: Alignment.center,
                              decoration: BoxDecoration(
                                color: Colors.grey[300],
                                borderRadius: const BorderRadius.horizontal(
                                  right: Radius.circular(10),
                                ),
                              ),
                              child: const Icon(
                                Icons.calendar_month,
                                size: 20,
                                color: Colors.black,
                              ),
                            ),
                          ],
                        ),
                      ),
                    ),
                    const SizedBox(height: 15),
                    const Align(
                      alignment: Alignment.centerLeft,
                      child: Text(
                        'Spol',
                      ),
                    ),
                    const SizedBox(height: 15),
                    Row(
                      children: [
                        Expanded(
                          child: RadioListTile<Spol>(
                            value: Spol.musko,
                            groupValue: controller.spol.value,
                            activeColor: AppColors.orange,
                            title: const Text('Muško'),
                            onChanged: (Spol? newValue) {
                              controller.spol.value = newValue;
                            },
                          ),
                        ),
                        Expanded(
                          child: RadioListTile<Spol>(
                            value: Spol.zensko,
                            groupValue: controller.spol.value,
                            activeColor: AppColors.orange,
                            title: const Text('Žensko'),
                            onChanged: (Spol? newValue) {
                              controller.spol.value = newValue;
                            },
                          ),
                        ),
                      ],
                    ),
                    const Spacer(),
                    SizedBox(
                      width: double.infinity,
                      child: ElevatedButton(
                        style: ButtonStyle(
                          backgroundColor:
                              MaterialStateProperty.all(AppColors.orange),
                        ),
                        child: const Text('Registracija'),
                        onPressed: () => controller.onPressRegister(),
                      ),
                    ),
                    const Spacer(),
                  ],
                ),
              ),
            ),
          ),
        ),
      ),
    );
  }
}
