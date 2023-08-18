import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:get/get.dart';

import '../../../models/feedback.dart';

class ReviewsController extends GetxController {
  final _api = Get.find<ApiService>();

  RxBool fetchingLoading = true.obs;
  RxList<Feedback> feedbacks = <Feedback>[].obs;

  @override
  void onInit() {
    getFeedbacks();
    super.onInit();
  }

  Future<void> getFeedbacks() async {
    fetchingLoading.value = true;
    feedbacks.clear();
    final response = await _api.get('/Feedback/getAll');
    if (response.status.isOk) {
      final responseJson = response.body as List<dynamic>;
      feedbacks.value = responseJson.map((e) => Feedback.fromJson(e)).toList();
    }
    fetchingLoading.value = false;
  }
}
