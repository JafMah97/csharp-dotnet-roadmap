# Module 05: Guided Project - Calculate and Print Student Grades

## Overview
This guided project automates the calculation of final grade averages for students in a class using basic arithmetic operations, explicit type casting, string interpolation, and escape sequences in C#.

---

## Technical Highlights

1. **Data Types & Explicit Casting:**
   * Stored numerical calculations using `decimal` to ensure floating-point accuracy when dividing integers.
   * Applied explicit casting `(decimal)` on the sum of integer assignment scores before performing division.

2. **Console Formatting:**
   * Utilized tab escape sequences (`\t`) to structure the console output into clear, aligned columns (`Student`, `Grade`).
   * Employed String Interpolation (`$""`) for clean variable printing.

---

## Problem Statement & Output

### Input Scores
* **Sophia:** 93, 87, 98, 95, 100
* **Nicolas:** 80, 83, 82, 88, 85
* **Zahirah:** 84, 96, 73, 85, 79
* **Jeong:** 90, 92, 98, 100, 97

### Expected & Rendered Console Output
```text
Student		Grade
Sophia		94.6	A
Nicolas		83.6	B
Zahirah		83.4	B
Jeong		95.4	A