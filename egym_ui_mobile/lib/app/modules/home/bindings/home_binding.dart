import 'package:egym_ui_mobile/app/modules/home/controllers/edit_profile_controller.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/termins_controller.dart';
import 'package:get/get.dart';

import '../controllers/home_controller.dart';
import '../controllers/reviews_controller.dart';
import '../controllers/workers_preview_controller.dart';

class HomeBinding extends Bindings {
  @override
  void dependencies() {
    Get.lazyPut(() => HomeController());
    Get.lazyPut(() => TerminsController());
    Get.lazyPut(() => WorkersPreviewController());
    Get.lazyPut(() => EditProfileController());
    Get.lazyPut(() => ReviewsController());
  }
}
