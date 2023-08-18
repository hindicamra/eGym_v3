import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/modules/home/controllers/home_controller.dart';
import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../../../models/service.dart';

class HomeScreen extends GetView<HomeController> {
  const HomeScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Obx(() {
      if (controller.servicesFetchStatus.value.isLoading) {
        return const Center(child: CircularProgressIndicator());
      }
      if (controller.services.isEmpty) {
        return const Center(
          child: Text('Trenutno nema dostupnih servisa'),
        );
      }
      return ListView.builder(
        itemCount: controller.services.length,
        itemBuilder: (context, index) => UslugaCard(
          service: controller.services[index],
        ),
      );
    });
  }
}

class UslugaCard extends StatelessWidget {
  final Service service;

  const UslugaCard({
    super.key,
    required this.service,
  });

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 15, vertical: 15),
      child: Column(
        crossAxisAlignment: CrossAxisAlignment.start,
        children: [
          Text(
            service.title,
            style: const TextStyle(
              fontWeight: FontWeight.bold,
              color: AppColors.orange,
              fontSize: 20,
            ),
          ),
          const SizedBox(height: 10),
          Text(
            service.desc,
            style: const TextStyle(
              fontStyle: FontStyle.italic,
              color: AppColors.darkGreyText,
            ),
          ),
          const SizedBox(height: 10),
          ClipRRect(
            borderRadius: const BorderRadius.only(
              topRight: Radius.circular(10),
              bottomLeft: Radius.circular(10),
              bottomRight: Radius.circular(25),
            ),
            child: SizedBox(
              width: double.infinity,
              child: Image.network(
                service.image,
                fit: BoxFit.fitWidth,
                errorBuilder: (_, __, ___) => const SizedBox(),
              ),
            ),
          ),
        ],
      ),
    );
  }
}
