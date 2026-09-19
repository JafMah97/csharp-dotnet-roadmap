<h1 align="center">Module 02 - Store & Retrieve Data Using Literals & Variables 💾</h1>

> **Status:** ✅ Completed  
> **Source:** Microsoft Learn / freeCodeCamp

---

## 🎯 Key Concepts Learned

### 1. Literals vs. Variables
* **Literal Values:** Hardcoded, constant values written directly into the source code (e.g., `"Jafar"`, `42`, `true`).
* **Variables:** Named memory locations used to store data values that can change during program execution. The variable name acts as a pointer to the memory location holding the data.

---

### 2. Basic C# Data Types

| Type | Description | Literal Example | Precision / Notes |
| :--- | :--- | :--- | :--- |
| **`char`** | Single Unicode character | `'A'` | Enclosed in single quotes |
| **`string`** | Text sequence | `"Hello"` | Enclosed in double quotes |
| **`int`** | Whole integer number | `42` | No decimal point |
| **`float`** | Floating-point number | `3.14159F` | 6–9 digits precision (requires `F` suffix) |
| **`double`** | Floating-point number | `3.14159265` | 15–17 digits precision (default decimal type) |
| **`decimal`** | High-precision decimal | `19.99M` | 28–29 digits precision (requires `M` suffix, best for financial data) |
| **`bool`** | Boolean flag | `true` / `false` | Used for logical evaluation and control flow |

---

### 3. Naming Conventions (`camelCase`)

1. **Allowed Characters:** Alphanumeric characters and underscores (`_`). Special characters like `&` or `*` are invalid.
2. **First Character:** Must start with a letter or an underscore (`_`). Starting with a digit (e.g., `1variable`) is forbidden. Underscores are typically reserved for private fields.
3. **Keywords & Case Sensitivity:** Variable names cannot be reserved C# keywords (like `int` or `class`). Names are case-sensitive (`myVar` $\neq$ `myvar`).
4. **Descriptive & Meaningful:** Use full words that explain intent. Avoid abbreviations/contractions (use `userCount` instead of `usrCnt`) and avoid adding data types into the name (use `message` instead of `stringMessage`).

---

### 4. Implicitly Typed Local Variables (`var`)

* **Compiler Inference:** The `var` keyword instructs the C# compiler to infer the type based on the initialization value.
* **Initialization Requirement:** Variables declared with `var` **must** be initialized immediately so the compiler can determine their type.
* **Use Cases:** Speeds up writing code when the type is obvious on the right-hand side, and becomes essential later when working with complex or anonymous types.

---

## 💻 Example Code

```csharp
// Explicit declaration
string developerName = "Jafar";
int completedModules = 2;
decimal courseRating = 4.99M;
bool isFinished = true;

// Implicit declaration (type inferred by compiler)
var currentTask = "Learning C#"; // Inferred as string

Console.WriteLine($"Developer: {developerName}");
Console.WriteLine($"Task: {currentTask}");