import 'package:egym_ui_mobile/app/modules/home/screens/edit_profile.dart';
import 'package:flutter/material.dart';

import 'package:get/get.dart';

import '../components/bottom_menu.dart';
import '../controllers/home_controller.dart';
import '../screens/home_screen.dart';
import '../screens/review.dart';
import '../screens/termins_preview.dart';
import '../screens/workers_preview.dart';

class HomeView extends GetView<HomeController> {
  const HomeView({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Obx(() {
        //if (controller.fetchingData.value) {
        //  return const Center(child: CircularProgressIndicator());
        //}
        return AnimatedSwitcher(
          duration: const Duration(milliseconds: 600),
          transitionBuilder: (Widget child, Animation<double> animation) {
            return FadeTransition(
              opacity: animation,
              child: child,
            );
          },
          child: body(),
        );
      }),
      bottomNavigationBar: const BottomMenu(),
    );
  }

  Widget body() {
    switch (controller.currentBottomIndex.value) {
      case 0:
        return const HomeScreen();
      case 1:
        return const TerminsPreview();
      case 2:
        return const WorkersPreview();
      case 3:
        return const Review();
      case 4:
        return const EditProfileScreen();
      default:
        return const SizedBox();
    }
  }
}
