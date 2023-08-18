import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/models/termin_type.dart';
import 'package:egym_ui_mobile/app/styles/text_field_decoration.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';
import 'package:intl/intl.dart';

import '../../../components/app_dropdown.dart';
import '../controllers/create_training_controller.dart';

class CreateTrainingView extends GetView<CreateTrainingController> {
  const CreateTrainingView({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        backgroundColor: Colors.transparent,
        elevation: 0,
        title: const Text('Kreiraj termin'),
        centerTitle: true,
      ),
      body: Padding(
        padding: const EdgeInsets.symmetric(horizontal: 20),
        child: Obx(() {
          if (controller.fetchLoading.value) {
            return const Center(child: CircularProgressIndicator());
          }
          if (controller.workers.isEmpty) {
            return const Center(
              child: Text('Nema dostupnih trenera'),
            );
          }
          return SingleChildScrollView(
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                const SizedBox(height: 20),
                AppDropdown(
                  title: 'Trener',
                  currentValue: controller.trainer.value,
                  values: controller.workersNames,
                  onChange: (value) {
                    controller.trainer.value = value;
                  },
                ),
                const SizedBox(height: 15),
                AppDropdown(
                  title: 'Vrsta termina',
                  currentValue: controller.trainingType.value,
                  values: TerminType.trainings,
                  onChange: (value) {
                    controller.trainingType.value = value;
                  },
                ),
                const SizedBox(height: 15),
                Row(
                  children: [
                    const Expanded(
                      flex: 2,
                      child: Text('Od datuma'),
                    ),
                    Expanded(
                      flex: 3,
                      child: GestureDetector(
                        onTap: () => controller.choseTrainingDateAndTime(
                          context,
                          isFromDate: true,
                        ),
                        child: Container(
                          height: 40,
                          width: double.infinity,
                          decoration: BoxDecoration(
                            border: Border.all(
                              color: AppColors.borderColor,
                              width: 0.8,
                            ),
                            borderRadius: BorderRadius.circular(5),
                          ),
                          child: Row(
                            children: [
                              Expanded(
                                child: Padding(
                                  padding: const EdgeInsets.symmetric(
                                    horizontal: 10,
                                  ),
                                  child: Text(
                                    controller.fromDate.value != null
                                        ? DateFormat('dd/MM/yyyy, HH:mm')
                                            .format(
                                            controller.fromDate.value!,
                                          )
                                        : '',
                                  ),
                                ),
                              ),
                              Container(
                                height: 48,
                                width: 32,
                                decoration: BoxDecoration(
                                  color: Colors.grey[300],
                                  borderRadius: const BorderRadius.horizontal(
                                    right: Radius.circular(5),
                                  ),
                                ),
                                child: const Icon(
                                  Icons.arrow_drop_down,
                                  size: 18,
                                  color: Colors.black,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 15),
                Row(
                  children: [
                    const Expanded(
                      flex: 2,
                      child: Text('Od datuma'),
                    ),
                    Expanded(
                      flex: 3,
                      child: GestureDetector(
                        onTap: () => controller.choseTrainingDateAndTime(
                          context,
                          isFromDate: false,
                        ),
                        child: Container(
                          height: 40,
                          width: double.infinity,
                          decoration: BoxDecoration(
                            border: Border.all(
                              color: AppColors.borderColor,
                              width: 0.8,
                            ),
                            borderRadius: BorderRadius.circular(5),
                          ),
                          child: Row(
                            children: [
                              Expanded(
                                child: Padding(
                                  padding: const EdgeInsets.symmetric(
                                    horizontal: 10,
                                  ),
                                  child: Text(
                                    controller.toDate.value != null
                                        ? DateFormat('dd/MM/yyyy, HH:mm')
                                            .format(
                                            controller.toDate.value!,
                                          )
                                        : '',
                                  ),
                                ),
                              ),
                              Container(
                                height: 48,
                                width: 32,
                                decoration: BoxDecoration(
                                  color: Colors.grey[300],
                                  borderRadius: const BorderRadius.horizontal(
                                    right: Radius.circular(5),
                                  ),
                                ),
                                child: const Icon(
                                  Icons.arrow_drop_down,
                                  size: 18,
                                  color: Colors.black,
                                ),
                              ),
                            ],
                          ),
                        ),
                      ),
                    ),
                  ],
                ),
                const SizedBox(height: 15),
                const Text(
                  'Opis',
                  style: TextStyle(fontSize: 16),
                ),
                const SizedBox(height: 15),
                TextField(
                  controller: controller.descController,
                  minLines: 5,
                  maxLines: 15,
                  decoration: appTextFieldDecoration(
                    hintText: 'Opis',
                    fillColor: false,
                    borderColor: AppColors.borderColor,
                  ),
                  textInputAction: TextInputAction.done,
                ),
                Align(
                  alignment: Alignment.center,
                  child: Padding(
                    padding: const EdgeInsets.symmetric(vertical: 30),
                    child: ElevatedButton(
                      style: const ButtonStyle(
                        elevation: MaterialStatePropertyAll(0),
                        backgroundColor: MaterialStatePropertyAll(
                          AppColors.orange,
                        ),
                      ),
                      child: const Text('    Spasi    '),
                      onPressed: () => controller.createNewTraining(),
                    ),
                  ),
                ),
              ],
            ),
          );
        }),
      ),
    );
  }
}
