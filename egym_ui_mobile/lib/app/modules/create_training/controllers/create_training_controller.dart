import 'package:egym_ui_mobile/app/controllers/user_controller.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:egym_ui_mobile/app/models/termin_type.dart';
import 'package:egym_ui_mobile/app/models/user.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/termins_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../../../constants/app_colors.dart';

class CreateTrainingController extends GetxController {
  final _api = Get.find<ApiService>();
  final _user = Get.find<UserController>().user.value!;

  RxBool fetchLoading = true.obs;
  List<User> workers = [];

  RxnString trainer = RxnString();
  RxnString trainingType = RxnString();
  Rxn<DateTime> fromDate = Rxn();
  Rxn<DateTime> toDate = Rxn();
  TextEditingController descController = TextEditingController();

  @override
  void onInit() async {
    fetchLoading.value = true;
    await fetchWorkers();
    await getRecommendation();
    fetchLoading.value = false;
    super.onInit();
  }

  Future<void> fetchWorkers() async {
    final workersList = await _api.getAllWorkers();
    if (workersList != null) {
      workers = workersList;
    }
  }

  Future<void> getRecommendation() async {
    final response = await _api.get(
      '/Recommendation',
      query: {"accountId": _user.id.toString()},
    );
    if (response.body != null && response.status.isOk) {
      int? employeeId = response.body[0]['employeeId'];
      int? reservationType = response.body[0]['reservationType'];
      if (employeeId != null) {
        trainer.value =
            workers.firstWhereOrNull((e) => e.id == employeeId)?.username ?? '';
      }
      if (reservationType != null) {
        trainingType.value = TerminType.trainingFromInt(reservationType);
      }
    }
  }

  List<String> get workersNames => workers.map((e) => e.username).toList();

  Future<void> choseTrainingDateAndTime(
    BuildContext context, {
    required bool isFromDate,
  }) async {
    final newDate = await showDatePicker(
      context: context,
      initialDate: DateTime.now(),
      firstDate: DateTime.now(),
      lastDate: DateTime.now().add(
        const Duration(days: 50),
      ),
    );

    if (newDate == null) return;

    // ignore: use_build_context_synchronously
    final time = await showTimePicker(
      context: context,
      initialTime: TimeOfDay.now(),
    );

    if (time == null) return;

    if (isFromDate) {
      fromDate.value = DateTime(
        newDate.year,
        newDate.month,
        newDate.day,
        time.hour,
        time.minute,
      );
    } else {
      toDate.value = DateTime(
        newDate.year,
        newDate.month,
        newDate.day,
        time.hour,
        time.minute,
      );
    }
  }

  Future<void> createNewTraining() async {
    if (trainer.value == null ||
        trainingType.value == null ||
        fromDate.value == null ||
        toDate.value == null) {
      Get.showSnackbar(const GetSnackBar(
        message: 'Molimo odaberite sva potrebna polja',
        backgroundColor: AppColors.error,
        snackPosition: SnackPosition.TOP,
        duration: Duration(seconds: 2),
      ));
      return;
    }

    final response = await _api.post('/Reservation', {
      "from": fromDate.value!.toIso8601String(),
      "to": toDate.value!.toIso8601String(),
      "description": descController.text.trim(),
      "reservationType": TerminType.trainingToInt(trainingType.value!),
      "accountId": _user.id,
      "employeeId": workers.firstWhere((e) => e.username == trainer.value).id,
    });

    if (response.status.isOk) {
      Get.find<TerminsController>().getUserTermins();
      Get.back();
      Get.snackbar(
        'Uspješno',
        'Zahtjev za termin uspješno poslan',
      );
    } else {
      Get.snackbar(
        'Greška',
        'Desila se greška. Molimo pokusajte ponovo kasnije',
      );
    }
    Get.back();
  }
}
