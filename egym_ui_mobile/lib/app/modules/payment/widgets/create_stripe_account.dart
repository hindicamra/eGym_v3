import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:get/get.dart';

import '../../../constants/app_colors.dart';
import '../../../styles/text_field_decoration.dart';
import '../../../utils/default_field_validator.dart';
import '../controllers/payment_controller.dart';

class CreateStripeAcc extends GetView<PaymentController> {
  const CreateStripeAcc({super.key});

  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 15),
        child: Form(
          key: controller.registrationFormKey,
          child: Column(
            children: [
              const Padding(
                padding: EdgeInsets.symmetric(vertical: 25),
                child: Text(
                  'Kako bi nastavili sa plaćanjem, potrebno je da napravite Stripe račun',
                  textAlign: TextAlign.center,
                  style: TextStyle(fontSize: 16),
                ),
              ),
              const SizedBox(height: 15),
              const Padding(
                padding: EdgeInsets.symmetric(vertical: 15),
                child: Align(
                  alignment: Alignment.centerLeft,
                  child: Text(
                    'VAŠI PODACI',
                    textAlign: TextAlign.left,
                    style: TextStyle(
                      fontWeight: FontWeight.bold,
                      color: AppColors.orange,
                    ),
                  ),
                ),
              ),
              TextFormField(
                initialValue: controller.email,
                decoration: appTextFieldDecoration(
                  hintText: 'Email',
                ),
                validator: defaultFieldValidator,
                onSaved: (newValue) {
                  controller.email = newValue!;
                },
              ),
              const SizedBox(height: 15),
              TextFormField(
                initialValue: controller.name,
                decoration: appTextFieldDecoration(
                  hintText: 'Korisničko ime',
                ),
                validator: defaultFieldValidator,
                onSaved: (newValue) {
                  controller.name = newValue!;
                },
              ),
              const Padding(
                padding: EdgeInsets.symmetric(vertical: 15),
                child: Align(
                  alignment: Alignment.centerLeft,
                  child: Text(
                    'PODACI KARTICE',
                    textAlign: TextAlign.left,
                    style: TextStyle(
                      fontWeight: FontWeight.bold,
                      color: AppColors.orange,
                    ),
                  ),
                ),
              ),
              TextFormField(
                initialValue: controller.cardHolderName,
                decoration: appTextFieldDecoration(
                  hintText: 'Ime i prezime vlasnika kartice',
                ),
                validator: defaultFieldValidator,
                onSaved: (newValue) {
                  controller.cardHolderName = newValue!;
                },
              ),
              const SizedBox(height: 15),
              TextFormField(
                keyboardType: TextInputType.number,
                maxLength: 16,
                decoration: appTextFieldDecoration(
                  hintText: 'Broj kartice',
                ),
                inputFormatters: <TextInputFormatter>[
                  FilteringTextInputFormatter.digitsOnly
                ],
                validator: (value) {
                  if (value!.length < 16) {
                    return 'Provjerite unos';
                  }
                  return null;
                },
                onSaved: (newValue) {
                  controller.cardNumber = newValue!;
                },
              ),
              const SizedBox(height: 15),
              TextFormField(
                keyboardType: TextInputType.number,
                maxLength: 3,
                decoration: appTextFieldDecoration(
                  hintText: 'CVC',
                ),
                inputFormatters: <TextInputFormatter>[
                  FilteringTextInputFormatter.digitsOnly
                ],
                validator: (value) {
                  if (value!.length < 3) {
                    return 'Provjerite unos';
                  }
                  return null;
                },
                onSaved: (newValue) {
                  controller.cvc = newValue!;
                },
              ),
              const SizedBox(height: 15),
              Row(
                children: [
                  Expanded(
                    child: TextFormField(
                      keyboardType: TextInputType.number,
                      maxLength: 2,
                      decoration: appTextFieldDecoration(
                        hintText: 'Mjeses isteka | 05',
                      ),
                      inputFormatters: <TextInputFormatter>[
                        FilteringTextInputFormatter.digitsOnly
                      ],
                      validator: (value) {
                        if (value!.length < 2) {
                          return 'Provjerite unos';
                        }
                        if (int.parse(value) > 12) {
                          return 'Provjerite unos';
                        }
                        return null;
                      },
                      onSaved: (newValue) {
                        controller.expirationMonth = newValue!;
                      },
                    ),
                  ),
                  const SizedBox(width: 15),
                  Expanded(
                    child: TextFormField(
                      keyboardType: TextInputType.number,
                      maxLength: 4,
                      decoration: appTextFieldDecoration(
                        hintText: 'Godina isteka | 2023',
                      ),
                      inputFormatters: <TextInputFormatter>[
                        FilteringTextInputFormatter.digitsOnly
                      ],
                      validator: (value) {
                        if (value!.length < 4) {
                          return 'Provjerite unos';
                        }
                        return null;
                      },
                      onSaved: (newValue) {
                        controller.expirationYear = newValue!;
                      },
                    ),
                  ),
                ],
              ),
              const SizedBox(height: 15),
              Obx(
                () => controller.registrationLoading.value
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
                          child: const Text('Završi registraciju'),
                          onPressed: () => controller.onPressRegister(),
                        ),
                      ),
              ),
              const SizedBox(height: 15),
            ],
          ),
        ),
      ),
    );
  }
}
