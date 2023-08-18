import 'package:egym_ui_mobile/app/components/app_dropdown.dart';
import 'package:egym_ui_mobile/app/models/activity.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/workers_preview_controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/svg.dart';
import 'package:get/get.dart';

import '../../../constants/app_colors.dart';

class WorkersPreview extends GetView<WorkersPreviewController> {
  const WorkersPreview({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        elevation: 0,
        title: const Text('Pregled aktivnosti uposlenika'),
        centerTitle: true,
      ),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: Obx(
          () {
            if (controller.fetchLoading.value) {
              return const Center(child: CircularProgressIndicator());
            }
            if (controller.workers.isEmpty) {
              return const Center(
                child: Text('Nema dostupnih uposlenika'),
              );
            }
            return Column(
              children: [
                Padding(
                  padding: const EdgeInsets.symmetric(vertical: 15),
                  child: AppDropdown(
                    title: 'Uposlenik',
                    currentValue: controller.trainer.value,
                    onChange: (value) {
                      controller.trainer.value = value;
                      controller.getWorkerActivity();
                    },
                    values: controller.workersNames,
                  ),
                ),
                Expanded(
                  child: controller.trainer.value == null
                      ? Center(
                          child: Column(
                            mainAxisAlignment: MainAxisAlignment.center,
                            children: [
                              SvgPicture.asset(
                                'assets/images/empty_preview.svg',
                                width: Get.size.width * .6,
                              ),
                              const SizedBox(height: 30),
                              const Padding(
                                padding: EdgeInsets.symmetric(horizontal: 50),
                                child: Text(
                                  'Izaberite uposlenika za kojeg želite pregledati aktivnost...',
                                  textAlign: TextAlign.center,
                                ),
                              ),
                            ],
                          ),
                        )
                      : controller.fetchActivityLoading.value
                          ? const Center(
                              child: CircularProgressIndicator(),
                            )
                          : SingleChildScrollView(
                              child: Table(
                                defaultVerticalAlignment:
                                    TableCellVerticalAlignment.middle,
                                border: TableBorder.all(
                                  color: AppColors.lightGrey,
                                  width: 2,
                                ),
                                columnWidths: const {
                                  0: FractionColumnWidth(.5),
                                  1: FractionColumnWidth(.5),
                                },
                                children: [
                                  tableHeader(),
                                  ...List.generate(
                                      controller.workerActivity.length,
                                      (index) {
                                    final training =
                                        controller.workerActivity[index];
                                    return trainingRow(
                                      training,
                                    );
                                  }),
                                ],
                              ),
                            ),
                )
              ],
            );
          },
        ),
      ),
    );
  }

  TableRow tableHeader() {
    return TableRow(
      decoration: BoxDecoration(color: Colors.grey[200]),
      children: const [
        Padding(
          padding: EdgeInsets.symmetric(
            vertical: 20,
            horizontal: 10,
          ),
          child: Text(
            'Mjesec',
            textAlign: TextAlign.center,
            style: TextStyle(fontWeight: FontWeight.bold),
          ),
        ),
        Padding(
          padding: EdgeInsets.symmetric(
            vertical: 20,
            horizontal: 10,
          ),
          child: Text(
            'Broj treninga',
            textAlign: TextAlign.center,
            style: TextStyle(fontWeight: FontWeight.bold),
          ),
        ),
      ],
    );
  }

  TableRow trainingRow(Activity activity) {
    return TableRow(
      children: [
        Padding(
          padding: const EdgeInsets.symmetric(
            vertical: 20,
            horizontal: 10,
          ),
          child: Text(
            activity.date,
            textAlign: TextAlign.center,
          ),
        ),
        Padding(
          padding: const EdgeInsets.symmetric(
            vertical: 20,
            horizontal: 10,
          ),
          child: Text(
            activity.numberOfReservation.toString(),
            textAlign: TextAlign.center,
          ),
        ),
      ],
    );
  }
}
