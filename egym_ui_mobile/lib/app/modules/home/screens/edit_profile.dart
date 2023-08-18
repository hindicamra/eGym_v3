import 'package:egym_ui_mobile/app/modules/home/controllers/edit_profile_controller.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';
import 'package:intl/intl.dart';

import '../../../constants/app_colors.dart';
import '../../../styles/text_field_decoration.dart';
import '../../../utils/default_field_validator.dart';

class EditProfileScreen extends GetView<EditProfileController> {
  const EditProfileScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SizedBox(
        height: Get.height - 50,
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 25),
          child: Obx(
            () => Form(
              key: controller.registrationFormKey,
              child: Column(
                children: [
                  const Spacer(flex: 3),
                  const Text(
                    'Uređivanje profila',
                    style: TextStyle(fontSize: 24),
                  ),
                  const Spacer(flex: 2),
                  TextFormField(
                    initialValue: controller.name,
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
                    initialValue: controller.surname,
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
                    initialValue: controller.nickname,
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
                    onSaved: (newValue) {
                      controller.password = newValue!;
                    },
                  ),
                  const SizedBox(height: 15),
                  const Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      'Datum rodjenja',
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
                  const Spacer(),
                  SizedBox(
                    width: double.infinity,
                    child: ElevatedButton(
                      style: ButtonStyle(
                        backgroundColor:
                            MaterialStateProperty.all(AppColors.orange),
                      ),
                      child: const Text('Spremi izmjene'),
                      onPressed: () => controller.onPressUpdate(),
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
