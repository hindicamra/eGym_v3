import 'package:egym_ui_mobile/app/modules/payment/controllers/payment_controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:get/get.dart';
import 'package:intl/intl.dart';

import '../../../constants/app_colors.dart';
import '../../../styles/text_field_decoration.dart';

class Payment extends GetView<PaymentController> {
  const Payment({super.key});

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: SizedBox(
        height: Get.size.height - kToolbarHeight - kBottomNavigationBarHeight,
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 15),
          child: Form(
            key: controller.paymentFormKey,
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                const Padding(
                  padding: EdgeInsets.symmetric(vertical: 10),
                  child: Text(
                    'Kako bi potvrdili termin, potrebno je izvršiti plaćanje istog',
                    style: TextStyle(fontSize: 16),
                  ),
                ),
                const Padding(
                  padding: EdgeInsets.symmetric(vertical: 15),
                  child: Align(
                    alignment: Alignment.centerLeft,
                    child: Text(
                      'PODACI O PLAĆANJU',
                      textAlign: TextAlign.left,
                      style: TextStyle(
                        fontWeight: FontWeight.bold,
                        color: AppColors.orange,
                      ),
                    ),
                  ),
                ),
                infoRow(
                  'Trener',
                  controller.termin.employeeName,
                ),
                infoRow(
                  'Vrsta termina / treninga',
                  controller.termin.reservationType.toUpperCase(),
                ),
                infoRow(
                  'Od datuma',
                  DateFormat('dd.MM.yyyy  HH:mm')
                      .format(controller.termin.from),
                ),
                infoRow(
                  'Do datuma',
                  DateFormat('dd.MM.yyyy  HH:mm').format(controller.termin.to),
                ),
                const SizedBox(height: 15),
                infoRow(
                  'Ukupno cijena',
                  '10 BAM',
                ),
                const SizedBox(height: 15),
                TextFormField(
                  keyboardType: TextInputType.number,
                  maxLength: 3,
                  decoration: appTextFieldDecoration(
                    hintText: 'CVC broj kartice',
                  ),
                  inputFormatters: <TextInputFormatter>[
                    FilteringTextInputFormatter.digitsOnly
                  ],
                  validator: (value) {
                    if (value!.length < 3) {
                      return 'Provjerite unos';
                    }
                    if (value.toString()[0].contains('0')) {
                      return 'Neispravan broj';
                    }
                    return null;
                  },
                  onSaved: (newValue) {
                    controller.paymentCvc = newValue!;
                  },
                ),
                const SizedBox(height: 15),
                TextFormField(
                  decoration: appTextFieldDecoration(
                    hintText: 'Dodatna napomena',
                  ),
                  onSaved: (newValue) {
                    controller.paymentDesc = newValue!;
                  },
                ),
                const Spacer(),
                Obx(
                  () => controller.payLoading.value
                      ? const Align(
                          alignment: Alignment.center,
                          child: CircularProgressIndicator(),
                        )
                      : SizedBox(
                          width: double.maxFinite,
                          child: ElevatedButton(
                            style: ButtonStyle(
                              backgroundColor:
                                  MaterialStateProperty.all(AppColors.orange),
                            ),
                            child: const Text('PLATI'),
                            onPressed: () => controller.onPressPay(),
                          ),
                        ),
                ),
                const SizedBox(height: 15),
              ],
            ),
          ),
        ),
      ),
    );
  }

  Widget infoRow(String title, String desc) {
    return Padding(
      padding: const EdgeInsets.only(bottom: 4),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Text(title),
          Text(
            desc,
            style: const TextStyle(fontWeight: FontWeight.bold),
          ),
        ],
      ),
    );
  }
}
