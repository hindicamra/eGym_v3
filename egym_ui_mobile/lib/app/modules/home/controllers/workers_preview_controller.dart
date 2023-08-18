import 'package:get/get.dart';

import '../../../services/api_service.dart';
import '../../../models/activity.dart';
import '../../../models/user.dart';

class WorkersPreviewController extends GetxController {
  final _api = Get.find<ApiService>();
//  final _user = Get.find<UserController>().user.value!;

  RxBool fetchLoading = true.obs;
  RxBool fetchActivityLoading = false.obs;
  List<User> workers = [];
  List<Activity> workerActivity = [];
  RxnString trainer = RxnString();

  @override
  void onInit() {
    fetchWorkers();
    super.onInit();
  }

  Future<void> fetchWorkers() async {
    fetchLoading.value = true;
    final workersList = await _api.getAllWorkers();
    if (workersList != null) {
      workers = workersList;
    }
    fetchLoading.value = false;
  }

  List<String> get workersNames => workers.map((e) => e.username).toList();

  Future<void> getWorkerActivity() async {
    fetchActivityLoading.value = true;
    workerActivity.clear();
    final workerId = workers.firstWhere((e) => e.username == trainer.value).id;
    final response = await _api.get('/Employee/activity', query: {
      "employeeId": workerId.toString(),
    });
    if (response.status.isOk) {
      final responseJson = response.body as List<dynamic>;
      workerActivity = responseJson.map((e) => Activity.fromJson(e)).toList();
    }
    fetchActivityLoading.value = false;
  }
}
