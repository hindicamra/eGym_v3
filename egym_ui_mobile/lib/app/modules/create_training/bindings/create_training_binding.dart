import 'package:get/get.dart';

import '../controllers/create_training_controller.dart';

class CreateTrainingBinding extends Bindings {
  @override
  void dependencies() {
    Get.lazyPut<CreateTrainingController>(
      () => CreateTrainingController(),
    );
  }
}
