// ignore_for_file: prefer_const_constructors

import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/termins_controller.dart';
import 'package:egym_ui_mobile/app/routes/app_pages.dart';
import 'package:flutter/material.dart';
import 'package:flutter_svg/flutter_svg.dart';
import 'package:get/get.dart';
import 'package:intl/intl.dart';

import '../../../models/termin.dart';

class TerminsPreview extends GetView<TerminsController> {
  const TerminsPreview({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Termini'),
        centerTitle: true,
        backgroundColor: Colors.transparent,
        elevation: 0,
        actions: [
          IconButton(
            onPressed: () => showInfoSheet(),
            icon: const Icon(Icons.info),
          )
        ],
      ),
      body: Column(
        children: [
          Obx(() {
            if (controller.isLoading.value) {
              return const Expanded(
                child: Center(child: CircularProgressIndicator()),
              );
            }
            return Expanded(
              child: controller.trainings.isEmpty
                  ? Center(
                      child: Column(
                        mainAxisAlignment: MainAxisAlignment.center,
                        children: [
                          SvgPicture.asset(
                            'assets/images/meditation.svg',
                            width: Get.size.width * .6,
                          ),
                          const SizedBox(height: 20),
                          const Text('Trenutno nema termina'),
                        ],
                      ),
                    )
                  : SingleChildScrollView(
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 15),
                        child: Table(
                          defaultVerticalAlignment:
                              TableCellVerticalAlignment.middle,
                          border: TableBorder.all(
                            color: AppColors.lightGrey,
                            width: 2,
                          ),
                          columnWidths: const {
                            0: FractionColumnWidth(.3),
                            1: FractionColumnWidth(.4),
                            2: FractionColumnWidth(.3),
                          },
                          children: [
                            tableHeader(),
                            ...List.generate(controller.trainings.length,
                                (index) {
                              final training = controller.trainings[index];
                              return trainingRow(
                                training,
                                onTap: training.status == 2
                                    ? () {
                                        Get.toNamed(
                                          Routes.PAYMENT,
                                          arguments:
                                              controller.trainings[index],
                                        );
                                      }
                                    : null,
                              );
                            }),
                          ],
                        ),
                      ),
                    ),
            );
          }),
          Padding(
            padding: const EdgeInsets.symmetric(vertical: 15),
            child: ElevatedButton(
              style: const ButtonStyle(
                elevation: MaterialStatePropertyAll(0),
                backgroundColor: MaterialStatePropertyAll(AppColors.orange),
              ),
              onPressed: () => Get.toNamed(Routes.CREATE_TRAINING),
              child: const Text('  Kreiraj novi  '),
            ),
          ),
        ],
      ),
    );
  }

  TableRow trainingRow(
    Termin termin, {
    VoidCallback? onTap,
  }) {
    Color color = Colors.transparent;
    switch (termin.status) {
      case 1:
        color = AppColors.statusPending;
        break;
      case 2:
        color = AppColors.statusConfirmed;
        break;
      case 3:
        color = AppColors.statusPaid;
        break;
      case 4:
        color = AppColors.statusDeclined;
    }

    return TableRow(
      decoration: BoxDecoration(color: color),
      children: [
        GestureDetector(
          onTap: onTap,
          child: Padding(
            padding: const EdgeInsets.symmetric(
              vertical: 20,
              horizontal: 10,
            ),
            child: Text(
              termin.employeeName,
              textAlign: TextAlign.center,
            ),
          ),
        ),
        GestureDetector(
          onTap: onTap,
          child: Padding(
            padding: const EdgeInsets.symmetric(
              vertical: 20,
              horizontal: 10,
            ),
            child: Text(
              DateFormat('d/M/yyyy, HH:mm').format(termin.from),
              textAlign: TextAlign.center,
            ),
          ),
        ),
        GestureDetector(
          onTap: onTap,
          child: Padding(
            padding: const EdgeInsets.symmetric(
              vertical: 20,
              horizontal: 10,
            ),
            child: Text(
              termin.reservationType,
              textAlign: TextAlign.center,
            ),
          ),
        ),
      ],
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
            'Trener',
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
            'Datum',
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
            'Vrsta termina',
            textAlign: TextAlign.center,
            style: TextStyle(fontWeight: FontWeight.bold),
          ),
        ),
      ],
    );
  }

  showInfoSheet() {
    Get.bottomSheet(
      Container(
        padding: const EdgeInsets.symmetric(vertical: 15, horizontal: 5),
        decoration: const BoxDecoration(
          color: Colors.white,
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          mainAxisSize: MainAxisSize.min,
          children: const [
            Padding(
              padding: EdgeInsets.only(left: 15, bottom: 15),
              child: Text(
                'Status termina',
                style: TextStyle(
                  fontSize: 16,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
            ListTile(
              leading: CircleAvatar(backgroundColor: AppColors.statusPending),
              title: Text('Na čekanju'),
              subtitle: Text(
                'Potrebno je da trener odobri termin koji ste kreirali',
                style: TextStyle(fontSize: 12),
              ),
            ),
            ListTile(
              leading: CircleAvatar(backgroundColor: AppColors.statusConfirmed),
              title: Text('Potvrđeno'),
              subtitle: Text(
                'Trener je potvrdio termin, potrebno je izvršiti plaćanje',
                style: TextStyle(fontSize: 12),
              ),
            ),
            ListTile(
              leading: CircleAvatar(backgroundColor: AppColors.statusPaid),
              title: Text('Plaćeno'),
              subtitle: Text(
                'Termin uspješno plaćen',
                style: TextStyle(fontSize: 12),
              ),
            ),
            ListTile(
              leading: CircleAvatar(backgroundColor: AppColors.statusDeclined),
              title: Text('Odbijeno'),
              subtitle: Text(
                'Trener je odbio termin koji ste kreirali',
                style: TextStyle(fontSize: 12),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
