# Module 04: Perform Basic Operations on Numbers in C#

## Overview
This module covers fundamental numerical operations, implicit and explicit data type conversions, operator precedence, and arithmetic operators in C#. It also explores the critical differences between floating-point types (`float`, `double`) and exact decimal types (`decimal`) when handling sensitive or precise data.

---

## Key Learning Outcomes

### 1. Mathematical & Assignment Operators
* **Basic Arithmetic Operators:** `+` (Addition), `-` (Subtraction), `*` (Multiplication), `/` (Division), and `%` (Modulus / Remainder).
* **Exponentiation:** Calculated using `System.Math.Pow(base, exponent)`.
* **Compound Assignment Operators:** `+=`, `-=`, `*=`, `/=`.
* **Increment & Decrement Operators:**
  * `value++` / `value--` (Postfix): Evaluates the current value first, then increments/decrements.
  * `++value` / `--value` (Prefix): Increments/decrements first, then evaluates the new value.

### 2. Overloaded Operators & Parentheses `()`
An **Overloaded Operator** is an operator that performs different actions based on the data types of its operands:
* `+` Operator: Performs numerical addition when used with numbers, but performs **string concatenation** when used with strings.
* `()` Parentheses Symbol: Serves multiple distinct roles in C#:
  1. **Method Invocation:** e.g., `Console.WriteLine()`
  2. **Order of Operations:** Enforcing mathematical precedence.
  3. **Casting Operator:** Explicitly converting data types, e.g., `(decimal)5`.

### 3. Mixed Types & Implicit Conversion
* Combining strings and numbers with `+` results in implicit conversion of numbers to strings.
* Evaluation moves **left-to-right**. Without parentheses, `"Value: " + 7 + 7` outputs `"Value: 77"`.
* Enclosing arithmetic inside parentheses `"Value: " + (7 + 7)` enforces addition first, outputting `"Value: 14"`.

### 4. Precision: `float` vs. `double` vs. `decimal`
* **`float` & `double` (Binary Floating-Point / IEEE 754):**
  * Store numbers in base-2 (binary).
  * Cannot represent certain decimal fractions (like `0.1` or `0.43`) with exact precision, leading to small rounding discrepancies (e.g., `812.3 - 242.43 = 569.8699999999999`).
  * Ideal for games, physics simulations, and scientific computing where performance is critical and tiny precision loss is acceptable.
* **`decimal` (128-bit Floating-Point):**
  * Stores numbers in base-10 (decimal format).
  * Guarantees absolute precision without binary conversion errors.
  * Essential for **financial, monetary, and inventory calculations**.

### 5. Division & Casting Behavior
* Integer division (`int / int`) discards any remainder and truncates the decimal part (e.g., `7 / 5` yields `1`).
* To obtain a decimal result:
  * The quotient (assigned variable) must be of type `decimal`.
  * At least one operand must explicitly be a `decimal` literal or cast using explicit conversion:
    ```csharp
    decimal quotient = (decimal)7 / 5; // Result: 1.4
    ```

---

## Challenge Summary: Fahrenheit to Celsius Converter

### Objective
Write a C# program to convert a temperature value from Fahrenheit to Celsius using the standard mathematical formula:
$$\text{Celsius} = (\text{Fahrenheit} - 32) \times \frac{5}{9}$$

### Implementation
```csharp
int fahrenheit = 94;
decimal fiveNinths = (decimal)5 / 9;
decimal celsius = (fahrenheit - 32) * fiveNinths;

Console.WriteLine($"The temperature is {celsius} Celsius.");
// Output: The temperature is 34.444444444444444444444444447 Celsius.