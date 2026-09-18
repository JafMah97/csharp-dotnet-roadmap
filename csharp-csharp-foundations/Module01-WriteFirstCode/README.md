<h1 align="center">Module 01 - Write Your First C# Code 🚀</h1>

> **Status:** ✅ Completed  
> **Source:** Microsoft Learn / freeCodeCamp

---

## 🎯 Key Concepts Learned

### 1. Core Language Characteristics
* **Compiled Language:** C# code is compiled into IL (Intermediate Language) and executed by the .NET runtime.
* **Type-Safe & Case-Sensitive:** Variables and types are strictly checked, and casing matters (`Console` is different from `console`).
* **Object-Oriented Programming (OOP):** Built around objects and classes to structure applications.

### 2. Output & Console Methods
We introduced the **`Console`** class and its two primary methods for printing output:
* **`Console.WriteLine()`**: Prints the value to the console and **appends a new line** at the end.
* **`Console.Write()`**: Prints the value to the console **without adding a line break**, leaving the cursor on the same line.

### 3. Data Literals & Syntax Rules
* **Character Literals (`char`):** Defined using **single quotation marks** (`'a'`).
* **String Literals (`string`):** Defined using **double quotation marks** (`"Hello World!"`).
* **Statements:** Every C# code statement **must end with a semicolon** `;`.
* **Single-Line Comments:** Written using two forward slashes (`//`).

---

## 💻 Example Code

```csharp
// Single-line comment explaining the output
Console.WriteLine("Hello World!"); // Prints text with a new line
Console.Write("Congrats! ");       // Prints text on the same line
Console.Write("First C# App!");    // Continues on the same line