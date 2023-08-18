import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/modules/add_review/controllers/add_review_controller.dart';
import 'package:egym_ui_mobile/app/styles/text_field_decoration.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../../../components/app_dropdown.dart';

class AddReviewView extends GetView<AddReviewController> {
  const AddReviewView({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        elevation: 0,
        title: const Text('Recenzija'),
        centerTitle: true,
      ),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: Obx(
          () => SingleChildScrollView(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                const SizedBox(height: 20),
                AppDropdown(
                  title: 'Osoblje',
                  currentValue: controller.persons.value,
                  values: const <String>[
                    '1',
                    '2',
                    '3',
                    '4',
                    '5',
                  ],
                  onChange: (value) {
                    controller.persons.value = value;
                  },
                ),
                const SizedBox(height: 15),
                AppDropdown(
                  title: 'Oprema',
                  currentValue: controller.equipments.value,
                  values: const <String>[
                    '1',
                    '2',
                    '3',
                    '4',
                    '5',
                  ],
                  onChange: (value) {
                    controller.equipments.value = value;
                  },
                ),
                const SizedBox(height: 15),
                AppDropdown(
                  title: 'Kvalitet usluga',
                  currentValue: controller.quality.value,
                  values: const <String>[
                    '1',
                    '2',
                    '3',
                    '4',
                    '5',
                  ],
                  onChange: (value) {
                    controller.quality.value = value;
                  },
                ),
                const SizedBox(height: 15),
                const Text(
                  'Komentar',
                  style: TextStyle(fontSize: 16),
                ),
                const SizedBox(height: 15),
                TextField(
                  controller: controller.commentController,
                  minLines: 5,
                  maxLines: 15,
                  decoration: appTextFieldDecoration(
                    hintText: 'Upiši komentar',
                    fillColor: false,
                    borderColor: AppColors.borderColor,
                  ),
                  textInputAction: TextInputAction.done,
                ),
                Align(
                  alignment: Alignment.center,
                  child: Padding(
                    padding: const EdgeInsets.symmetric(vertical: 30),
                    child: ElevatedButton(
                      style: const ButtonStyle(
                        elevation: MaterialStatePropertyAll(0),
                        backgroundColor: MaterialStatePropertyAll(
                          AppColors.orange,
                        ),
                      ),
                      child: const Text('    Spasi    '),
                      onPressed: () => controller.onPressSubbmit(),
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
