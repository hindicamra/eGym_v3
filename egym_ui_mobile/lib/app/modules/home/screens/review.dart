import 'package:egym_ui_mobile/app/modules/home/controllers/reviews_controller.dart';
import 'package:egym_ui_mobile/app/routes/app_pages.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:get/get.dart';

import '../../../constants/app_colors.dart';

class Review extends GetView<ReviewsController> {
  const Review({super.key});

  @override
  Widget build(BuildContext context) {
    return Center(
      child: Obx(() {
        if (controller.fetchingLoading.value) {
          return const Center(child: CircularProgressIndicator());
        }
        if (controller.feedbacks.isEmpty) {
          return Column(
            mainAxisAlignment: MainAxisAlignment.center,
            children: [
              const Spacer(flex: 3),
              SvgPicture.asset(
                'assets/images/review.svg',
                width: Get.size.width * .6,
              ),
              const SizedBox(height: 30),
              const Padding(
                padding: EdgeInsets.symmetric(horizontal: 50),
                child: Text(
                  'Želiš ostaviti svoju recenziju kako bi i drugi saznali što više o nama? \n\nMožeš to učiniti u nastavku...',
                  textAlign: TextAlign.center,
                ),
              ),
              const Spacer(),
              ElevatedButton(
                style: const ButtonStyle(
                  elevation: MaterialStatePropertyAll(0),
                  backgroundColor: MaterialStatePropertyAll(
                    AppColors.orange,
                  ),
                ),
                child: const Text('    Ostavi rezenziju    '),
                onPressed: () => Get.toNamed(Routes.ADD_REVIEW),
              ),
              const Spacer(),
            ],
          );
        }

        return SafeArea(
          child: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 10),
            child: ListView(
              children: [
                ...List.generate(
                  controller.feedbacks.length,
                  (index) => Padding(
                    padding: const EdgeInsets.only(top: 10),
                    child: Card(
                      child: Padding(
                        padding: const EdgeInsets.symmetric(vertical: 8),
                        child: ListTile(
                          leading: const CircleAvatar(
                            backgroundColor: AppColors.orange,
                            child: Icon(
                              Icons.person,
                              color: Colors.white,
                            ),
                          ),
                          title: Text(
                            '${controller.feedbacks[index].username}\n',
                            style: const TextStyle(
                              fontSize: 16,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          subtitle: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              if (controller
                                  .feedbacks[index].comment.isNotEmpty)
                                Text(
                                  '${controller.feedbacks[index].comment}\n',
                                ),
                              Text(
                                'Oprema - ${controller.feedbacks[index].equipment.toString()}',
                              ),
                              Text(
                                'Uposlenici - ${controller.feedbacks[index].employees.toString()}',
                              ),
                              Text(
                                'Kvalitet usluga - ${controller.feedbacks[index].serviceQuality.toString()}',
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.symmetric(vertical: 15),
                  child: SizedBox(
                    width: double.infinity,
                    child: ElevatedButton(
                      style: const ButtonStyle(
                        elevation: MaterialStatePropertyAll(0),
                        backgroundColor: MaterialStatePropertyAll(
                          AppColors.orange,
                        ),
                      ),
                      child: const Text('    Ostavi rezenziju    '),
                      onPressed: () => Get.toNamed(Routes.ADD_REVIEW),
                    ),
                  ),
                ),
              ],
            ),
          ),
        );
      }),
    );
  }
}
