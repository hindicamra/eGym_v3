import 'package:flutter/material.dart';

import '../constants/app_colors.dart';

InputDecoration appTextFieldDecoration({
  String? hintText,
  double borderRadius = 10,
  bool enableBorder = true,
  Color? borderColor,
  bool fillColor = true,
}) {
  return InputDecoration(
    fillColor: AppColors.fieldColor,
    filled: fillColor,
    hintText: hintText,
    hintStyle: const TextStyle(
      color: AppColors.hintText,
    ),
    isDense: true,
    enabledBorder: OutlineInputBorder(
      borderRadius: BorderRadius.circular(borderRadius),
      borderSide: BorderSide(
        width: enableBorder ? 1.0 : 0.0,
        color: borderColor ?? AppColors.lightGrey.withOpacity(0.6),
      ),
    ),
    focusedBorder: OutlineInputBorder(
      borderRadius: BorderRadius.circular(borderRadius),
      borderSide: BorderSide(
        width: enableBorder ? 1.0 : 0.0,
        color: borderColor ?? AppColors.lightGrey.withOpacity(0.6),
      ),
    ),
    focusedErrorBorder: OutlineInputBorder(
      borderRadius: BorderRadius.circular(borderRadius),
      borderSide: BorderSide(
        width: 0.3,
        color: borderColor ?? AppColors.error.withOpacity(0.6),
      ),
    ),
    errorBorder: OutlineInputBorder(
      borderRadius: BorderRadius.circular(borderRadius),
      borderSide: BorderSide(
        width: 0.5,
        color: borderColor ?? AppColors.error.withOpacity(0.6),
      ),
    ),
  );
}
