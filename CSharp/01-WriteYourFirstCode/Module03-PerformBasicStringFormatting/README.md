# Module 03: Perform Basic String Formatting in C#

## Overview
In this module, I learned how to format text in C# using various string manipulation techniques including escape sequences, verbatim literals, Unicode, concatenation, and interpolation.

---

## Key Concepts Learned

### 1. Character Escape Sequences
Special character sequences prefixed with a backslash `\` to format strings:
* `\n`: New line
* `\t`: Tab space
* `\"`: Escape double quotation
* `\'`: Escape single quotation
* `\\`: Escape backslash

### 2. Verbatim String Literal (`@`)
* **What is it?** A way to define strings literally without needing character escape sequences for backslashes or new lines.
* **Usage:** Prefix the string literal with the `@` directive (e.g., `@"C:\Users\Projects"`).
* **Double Quotes:** To include a literal double quotation mark inside a verbatim string, double it up (`""`).

### 3. Unicode Escape Characters (`\u`)
* **What is it?** A method to output characters that aren't on standard English keyboards using hexadecimal encoding.
* **Why use it?**
  1. Enhanced UI / Emojis.
  2. Avoid file encoding issues across different platforms.
  3. Represent invisible characters like Non-Breaking Space (`\u00A0`).
  4. Localization support (e.g., Arabic, Japanese, Cyrillic).
  5. Mathematical operators and special symbols.
* **Usage:** Add `\u` followed by the 4-digit hexadecimal code (e.g., `\u00A9` for `©`).

### 4. String Concatenation (`+`)
Combining two or more strings together using the `+` operator.

### 5. String Interpolation (`$`)
* **What is it?** Combining variable values and string literals using templates and expressions inside `{}` braces.
* **Combined Usage (`$@"` / `@$"`):** Enables both string interpolation and verbatim literal rules simultaneously.

---

## Challenge Solution Summary
Formatted instructions in both English and Russian using a maximum of two `Console.WriteLine()` statements combined with `@$` interpolation.