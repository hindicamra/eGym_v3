// ignore_for_file: constant_identifier_names

part of 'app_pages.dart';

abstract class Routes {
  Routes._();
  static const HOME = _Paths.HOME;
  static const LOGIN = _Paths.LOGIN;
  static const REGISTRATION = _Paths.REGISTRATION;
  static const CREATE_TRAINING = _Paths.CREATE_TRAINING;
  static const ADD_REVIEW = _Paths.ADD_REVIEW;
  static const LOGIN_ADMIN = _Paths.LOGIN_ADMIN;
  static const HOME_ADMIN = _Paths.HOME_ADMIN;
  static const WORKERS = _Paths.WORKERS;
  static const REPORT_CREATION = _Paths.REPORT_CREATION;
  static const USERS = _Paths.USERS;
  static const TRAINING_OVERVIEW = _Paths.TRAINING_OVERVIEW;
  static const APPOINTMENT_REQUESTS = _Paths.APPOINTMENT_REQUESTS;
  static const DIET_PLAN = _Paths.DIET_PLAN;
  static const PAYMENT = _Paths.PAYMENT;
}

abstract class _Paths {
  _Paths._();
  static const HOME = '/home';
  static const LOGIN = '/login';
  static const REGISTRATION = '/registration';
  static const CREATE_TRAINING = '/create-training';
  static const ADD_REVIEW = '/add-review';
  static const LOGIN_ADMIN = '/login-admin';
  static const HOME_ADMIN = '/home-admin';
  static const WORKERS = '/workers';
  static const REPORT_CREATION = '/report-creation';
  static const USERS = '/users';
  static const TRAINING_OVERVIEW = '/training-overview';
  static const APPOINTMENT_REQUESTS = '/appointment-requests';
  static const DIET_PLAN = '/diet-plan';
  static const PAYMENT = '/payment';
}
