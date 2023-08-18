import 'dart:io';

import 'package:get/get.dart';

import '../modules/payment/bindings/payment_binding.dart';
import '../modules/payment/views/payment_view.dart';
import '../modules/add_review/bindings/add_review_binding.dart';
import '../modules/add_review/views/add_review_view.dart';
import '../modules/create_training/bindings/create_training_binding.dart';
import '../modules/create_training/views/create_training_view.dart';
import '../modules/home/bindings/home_binding.dart';
import '../modules/home/views/home_view.dart';
import '../modules/login/bindings/login_binding.dart';
import '../modules/login/views/login_view.dart';
import '../modules/registration/bindings/registration_binding.dart';
import '../modules/registration/views/registration_view.dart';

// ignore_for_file: constant_identifier_names
// ignore_for_file: non_constant_identifier_names

part 'app_routes.dart';

class AppPages {
  AppPages._();

  static final INITIAL = Platform.isWindows ? Routes.LOGIN_ADMIN : Routes.LOGIN;

  static final routes = [
    // USER
    GetPage(
      name: _Paths.HOME,
      page: () => const HomeView(),
      binding: HomeBinding(),
    ),
    GetPage(
      name: _Paths.LOGIN,
      page: () => const LoginView(),
      binding: LoginBinding(),
    ),
    GetPage(
      name: _Paths.REGISTRATION,
      page: () => const RegistrationView(),
      binding: RegistrationBinding(),
    ),
    GetPage(
      name: _Paths.CREATE_TRAINING,
      page: () => const CreateTrainingView(),
      binding: CreateTrainingBinding(),
    ),
    GetPage(
      name: _Paths.ADD_REVIEW,
      page: () => const AddReviewView(),
      binding: AddReviewBinding(),
    ),
    GetPage(
      name: _Paths.PAYMENT,
      page: () => const PaymentView(),
      binding: PaymentBinding(),
    ),
  ];
}
