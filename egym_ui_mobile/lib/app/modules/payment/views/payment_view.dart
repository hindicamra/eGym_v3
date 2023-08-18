import 'package:flutter/material.dart';
import 'package:get/get.dart';

import '../controllers/payment_controller.dart';
import '../widgets/create_stripe_account.dart';
import '../widgets/payment.dart';

class PaymentView extends GetView<PaymentController> {
  const PaymentView({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Plaćanje'),
        elevation: 0,
        backgroundColor: Colors.transparent,
        centerTitle: true,
      ),
      body: Obx(() {
        if (controller.fetchStatus.value.isLoading) {
          return const Center(child: CircularProgressIndicator());
        }
        return controller.userHaveStripe.value
            ? const Payment()
            : const CreateStripeAcc();
      }),
    );
  }
}
