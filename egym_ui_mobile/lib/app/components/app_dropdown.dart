import 'package:flutter/material.dart';

import '../constants/app_colors.dart';

class AppDropdown extends StatelessWidget {
  final String title;
  final dynamic currentValue;
  final List<dynamic> values;
  final ValueChanged onChange;

  const AppDropdown({
    super.key,
    required this.title,
    required this.onChange,
    required this.values,
    this.currentValue,
  });

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        Expanded(
          flex: 2,
          child: Text(
            title,
            style: const TextStyle(fontSize: 16),
          ),
        ),
        Expanded(
          flex: 3,
          child: Container(
            height: 40,
            decoration: BoxDecoration(
              border: Border.all(
                color: AppColors.borderColor,
                width: 0.8,
              ),
              borderRadius: BorderRadius.circular(5),
            ),
            child: DropdownButton(
              underline: const SizedBox.shrink(),
              isExpanded: true,
              value: currentValue,
              itemHeight: 48,
              iconSize: 48,
              icon: FittedBox(
                child: Container(
                  height: 48,
                  width: 40,
                  decoration: BoxDecoration(
                    color: Colors.grey[300],
                    borderRadius: const BorderRadius.horizontal(
                      right: Radius.circular(5),
                    ),
                  ),
                  child: const Icon(
                    Icons.arrow_drop_down,
                    size: 22,
                    color: Colors.black,
                  ),
                ),
              ),
              items: <String>[...values]
                  .map<DropdownMenuItem<String>>((String value) {
                return DropdownMenuItem<String>(
                  value: value,
                  child: FittedBox(
                    child: Padding(
                      padding: const EdgeInsets.symmetric(
                        horizontal: 10,
                      ),
                      child: Text(
                        value,
                        style: const TextStyle(
                          fontSize: 14,
                        ),
                      ),
                    ),
                  ),
                );
              }).toList(),
              onChanged: (value) {
                onChange(value);
              },
            ),
          ),
        ),
      ],
    );
  }
}
