import 'package:egym_ui_mobile/app/controllers/user_controller.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/reviews_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

class AddReviewController extends GetxController {
  final _api = Get.find<ApiService>();

  RxnString persons = RxnString();
  RxnString equipments = RxnString();
  RxnString quality = RxnString();
  TextEditingController commentController = TextEditingController();

  Future<void> onPressSubbmit() async {
    if (persons.value == null ||
        equipments.value == null ||
        quality.value == null) {
      Get.snackbar('Greška', 'Molimo odaberite sva polja');
      return;
    }
    final userId = Get.find<UserController>().user.value!.id;
    final response = await _api.post('/Feedback', {
      "employees": int.parse(persons.value!),
      "equipment": int.parse(equipments.value!),
      "serviceQuality": int.parse(quality.value!),
      "comment": commentController.text.trim(),
      "accountId": userId,
    });

    if (response.status.isOk) {
      Get.find<ReviewsController>().getFeedbacks();
      Get.back();
      Get.snackbar('Uspješno', 'Uspješno ste ostavili recenziju');
    } else {
      Get.snackbar('Greška', 'Desio se problem, molimo pokušajte ponovo');
    }
  }
}
