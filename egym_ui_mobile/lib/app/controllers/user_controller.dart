import 'package:egym_ui_mobile/app/models/user.dart';
import 'package:get/get.dart';

class UserController {
  Rxn<User?> user = Rxn();

  void setUser(User newUser) => user.value = newUser;
}
