import 'dart:convert';
import 'dart:developer';
import 'package:egym_ui_mobile/app/models/user.dart';
import 'package:get/get.dart';

class ApiService extends GetConnect {
  String logColor = '\x1B[36m';
  String? basicAuth;

  @override
  onInit() {
    httpClient.timeout = const Duration(seconds: 20);
    // CMD > ipconfig > Wireless LAN adapter Wi-Fi (IPv4 Address)
    httpClient.baseUrl = 'http://192.168.0.15:5192';
    // REQUEST
    httpClient.maxRedirects = 3;
    httpClient.addRequestModifier<dynamic>((request) {
      request.headers['accept'] = 'application/json';
      if (basicAuth != null && basicAuth!.isNotEmpty) {
        if (!request.url.path.contains('/Account/login')) {
          request.headers['Authorization'] = basicAuth!;
        }
      }
      return request;
    });
    // RESPONSE
    httpClient.addResponseModifier((request, response) async {
      log(
        '$logColor\n\nENDPOINT: ${request.url.path}\nRESPONSE: ${response.body}\n\n.',
        name: 'API',
      );
      return response;
    });
  }

  void generateBasicAuth(String username, String password) {
    String newBasicAuth =
        'Basic ${base64.encode(utf8.encode('$username:$password'))}';
    basicAuth = newBasicAuth;
  }

  Future<List<User>?> getAllWorkers() async {
    final response = await get('/Employee/getAll');
    if (response.status.isOk) {
      final users = response.body as List<dynamic>;
      return users.map((e) => User.fromJson(e)).toList();
    } else {
      return null;
    }
  }
}
