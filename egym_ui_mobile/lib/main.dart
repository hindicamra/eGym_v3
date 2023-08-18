import 'package:egym_ui_mobile/app/constants/app_colors.dart';
import 'package:egym_ui_mobile/app/controllers/user_controller.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

import 'package:get/get.dart';

import 'app/services/api_service.dart';
import 'app/routes/app_pages.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await SystemChrome.setPreferredOrientations(
    [DeviceOrientation.portraitUp],
  );

  Get.put(ApiService(), permanent: true);
  Get.put(UserController(), permanent: true);

  runApp(
    GestureDetector(
      onTap: () {
        FocusManager.instance.primaryFocus?.unfocus();
      },
      child: GetMaterialApp(
        debugShowCheckedModeBanner: false,
        theme: ThemeData(
          scaffoldBackgroundColor: AppColors.scaffoldBgColor,
          appBarTheme: const AppBarTheme(
            titleTextStyle: TextStyle(
              color: AppColors.orange,
              fontSize: 20,
              fontWeight: FontWeight.bold,
            ),
            iconTheme: IconThemeData(color: AppColors.orange),
          ),
          progressIndicatorTheme: const ProgressIndicatorThemeData(
            color: AppColors.orange,
          ),
        ),
        title: "eGym",
        initialRoute: AppPages.INITIAL,
        getPages: AppPages.routes,
      ),
    ),
  );
}
