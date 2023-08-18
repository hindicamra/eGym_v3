import 'package:egym_ui_mobile/app/controllers/user_controller.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/termins_controller.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:egym_ui_mobile/app/models/termin.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class PaymentController extends GetxController {
  static final user = Get.find<UserController>().user.value!;
  final _api = Get.find<ApiService>();

  Rx<RxStatus> fetchStatus = RxStatus.loading().obs;
  RxBool userHaveStripe = false.obs;

  // REGISTRATION
  final registrationFormKey = GlobalKey<FormState>();
  String email = user.email ?? '';
  String name = user.username;
  String cardHolderName = '${user.firstName} ${user.lastName}';
  String cardNumber = '';
  String expirationYear = '';
  String expirationMonth = '';
  String cvc = '';

  RxBool registrationLoading = false.obs;

  // PAYMENT
  final paymentFormKey = GlobalKey<FormState>();
  String stripeCustomerId = '';
  Termin termin = Get.arguments as Termin;
  String paymentCvc = '';
  String paymentDesc = '';

  RxBool payLoading = false.obs;

  @override
  void onInit() {
    super.onInit();
    checkStripeAccount();
  }

  Future<void> checkStripeAccount() async {
    fetchStatus.value = RxStatus.loading();
    final response = await _api.get('/Payment', query: {
      "accountId": user.id.toString(),
    });
    if (response.body.toString().contains('Invalid Account Id') &&
        response.statusCode != null) {
      userHaveStripe.value = false;
    } else {
      if (response.status.isOk) {
        userHaveStripe.value = true;
        stripeCustomerId = response.body['stripeCustomerId'];
      } else {
        userHaveStripe.value = false;
      }
    }
    fetchStatus.value = RxStatus.success();
  }

  Future<void> onPressRegister() async {
    final isValid = registrationFormKey.currentState!.validate();
    if (!isValid) return;
    registrationLoading.value = true;
    registrationFormKey.currentState!.save();

    if (!_isExpirationDateValid(expirationMonth, expirationYear)) {
      Get.snackbar('Greška', 'Izgleda da datum isteka nije validan');
      return;
    }

    final response = await _api.post('/Payment/addCustomer', {
      "email": email,
      "name": name,
      "accountId": user.id,
      "creditCard": {
        "name": cardHolderName,
        "cardNumber": cardNumber,
        "expirationYear": expirationYear,
        "expirationMonth": expirationMonth,
        "cvc": cvc,
      }
    });

    if (response.status.isOk) {
      checkStripeAccount();
      Get.snackbar('Uspješno', 'Registracija je bila uspješna');
    } else {
      Get.snackbar('Greška', 'Desila se greška, molimo pokušajte kasnije');
    }

    registrationLoading.value = false;
  }

  Future<void> onPressPay() async {
    final isValid = paymentFormKey.currentState!.validate();
    if (!isValid) return;
    payLoading.value = true;
    paymentFormKey.currentState!.save();

    final response = await _api.post('/Payment/addPayment', {
      "description": paymentDesc,
      "receiptEmail": user.email ?? 'egym_ui_mobile@test.test',
      "ccv": int.tryParse(paymentCvc),
      "currency": 'BAM',
      "amount": 1000,
      "customerId": stripeCustomerId,
      "reservationId": termin.reservationId,
    });
    if (response.status.isOk) {
      Get.find<TerminsController>().getUserTermins();
      Get.back();
      Get.snackbar('Uspješno', 'Placanje za termin uspješno');
    } else {
      Get.snackbar('Greška', 'Desila se greška, molimo pokupajte kasnije');
    }
    payLoading.value = false;
  }

  bool _isExpirationDateValid(String expirationMonth, String expirationYear) {
    DateTime now = DateTime.now();
    DateTime expirationDate = DateTime(
      int.parse(expirationYear),
      int.parse(expirationMonth),
      now.day,
    );

    if (expirationDate.isAfter(now.add(const Duration(days: 365 * 5)))) {
      return false;
    }

    return expirationDate.isAfter(now);
  }
}
