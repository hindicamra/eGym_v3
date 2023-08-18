import 'package:egym_ui_mobile/app/controllers/user_controller.dart';
import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:get/get.dart';

import '../../../models/termin.dart';

class TerminsController extends GetxController {
  final _api = Get.find<ApiService>();
  final _user = Get.find<UserController>().user.value!;

  RxBool isLoading = true.obs;
  RxList<Termin> trainings = <Termin>[].obs;

  @override
  void onInit() {
    getUserTermins();
    super.onInit();
  }

  Future<void> getUserTermins() async {
    trainings.clear();
    isLoading.value = true;
    final response = await _api.get('/Reservation/GetNewestByUser', query: {
      "userId": _user.id.toString(),
      "date": DateTime.now().toIso8601String(),
    });
    if (response.status.isOk) {
      final trainingsJson = response.body as List<dynamic>;
      trainings.addAll(trainingsJson.map((e) => Termin.fromJson(e)).toList());
    }
    isLoading.value = false;
  }
}
