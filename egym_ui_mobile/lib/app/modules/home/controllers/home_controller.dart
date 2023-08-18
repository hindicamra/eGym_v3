import 'package:egym_ui_mobile/app/services/api_service.dart';
import 'package:egym_ui_mobile/app/models/service.dart';
import 'package:get/get.dart';

class HomeController extends GetxController {
  final _api = Get.find<ApiService>();

  RxInt currentBottomIndex = 0.obs;

  Rx<RxStatus> servicesFetchStatus = RxStatus.loading().obs;
  RxList<Service> services = <Service>[].obs;

  @override
  void onInit() {
    super.onInit();
    getServices();
  }

  Future<void> getServices() async {
    servicesFetchStatus.value = RxStatus.loading();
    final response = await _api.get('/Service/getAll');
    if (response.status.isOk) {
      final responseJson = response.body as List<dynamic>;
      services.addAll(responseJson.map((e) => Service.fromJson(e)).toList());
      servicesFetchStatus.value = RxStatus.success();
    } else {
      servicesFetchStatus.value = RxStatus.error();
    }
  }
}
