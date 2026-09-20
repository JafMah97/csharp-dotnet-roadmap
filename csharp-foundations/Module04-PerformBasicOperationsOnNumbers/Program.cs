/* ================ Perform basic operations on numbers in C# ================ */
// 1.Add two numeric values

int firstNumber = 12;
int secondNumber = 123;

Console.WriteLine(firstNumber + secondNumber);

Console.Write("\n\n====================\n\n"); // Separator


//2.Mix data types to force implicit type conversions

string firstName = "Bob";
int widgetsSold = 7;

Console.WriteLine(firstName + " Sold " + widgetsSold + " Widgets");
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // more advanced case
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); //Add parentheses to clarify your intention to the compiler

// What is Overloaded Operator ? means an Operator have more than one Job , like the + operator to sum integers and Concatenate two or more strings
// another Overloaded Operator is the () parentheses symbol , we use it to after method name to invoke a method , or to form the order of operations

// NOTE:You should probably avoid performing both a calculation and concatenation in a single line of code. The point here is to help you understand how to view operators and operands the way the compiler does.
Console.Write("\n\n====================\n\n"); // Separator


//3. Perform math operations

// a-Sum
Console.WriteLine("Sum two Integers : 812 + 242 = " +(812 +242));
Console.WriteLine("Sum two Floats : 812.3 + 242.43 = " +(812.3F +242.43F));
Console.WriteLine("Sum two Doubles : 812.3 + 242.43 = " +(812.3 +242.43));
Console.WriteLine("Sum two Decimals : 812.3 + 242.43 = " +(812.3M +242.43M));

Console.WriteLine("==============="); //sub separator


// b-Subtraction
Console.WriteLine("subtraction of two Integers : 812 - 242 = " +(812 - 242));
Console.WriteLine("subtraction of two Floats : 812.3 - 242.43 = " +(812.3F - 242.43F)); //569.87 ?
Console.WriteLine("subtraction of two Doubles : 812.3 - 242.43 = " +(812.3 - 242.43)); //569.8699999999999 ?
Console.WriteLine("subtraction of two Decimals : 812.3 - 242.43 = " +(812.3M - 242.43M)); //569.87 ?

// Here we can see the difference between the float and the Decimal and Double more clearly 
/*
Even the Float have the less Precision , it represent the numbers in Binary => that leads to difference in numbers that because , computers can't store the fractions like 1/3 in precision 
  so double and Float Data type restore the closest near thing. when subtraction it will show this tiny difference .
  But Decimal Data type will store in Decimal counting system , the Problem not appear
  But why the Problem Does not appear in Float?
  because it has less Presicion => the method WriteLine have Rounded the number to the closest thing , and that is why

  conclusion:
  when the Persision matters like money we use decimal data type 
  when we need massive numbers in gaming or other application when the rounding does not matter we use double and float 

  that is very helpful lesson , when i was frontend developer , my teammate the backend developer always have some fraction difference in the money total for the customer inside the response , maybe this was a Possible why
*/ 
Console.WriteLine("==============="); //sub separator


// c- Multiplication
Console.WriteLine("Multiplication of two Integers : 812    * 242    = " +(812    * 242));
Console.WriteLine("Multiplication of two Floats   : 812.3  * 242.43 = " +(812.3F * 242.43F));
Console.WriteLine("Multiplication of two Doubles  : 812.3  * 242.43 = " +(812.3  * 242.43)); 
Console.WriteLine("Multiplication of two Decimals : 812.3  * 242.43 = " +(812.3M * 242.43M));

Console.WriteLine("==============="); //sub separator


// d- division 
// the quotient (left of the assignment operator) must be of type decimal and at least one of numbers being divided must also be of type decimal (both numbers can also be a decimal type).
Console.WriteLine("division of two Integers : 812    / 242    = " +(812    / 242)); //wrong value 
Console.WriteLine("division of two Floats   : 812.3  / 242.43 = " +(812.3F / 242.43F));
Console.WriteLine("division of two Doubles  : 812.3  / 242.43 = " +(812.3  / 242.43)); 
Console.WriteLine("division of two Decimals : 812.3  / 242.43 = " +(812.3M / 242.43M));

// those will work
// decimal decimalQuotient = 7 / 5.0m;
// decimal decimalQuotient = 7.0m / 5.0m;

// those will not
// int decimalQuotientA = 7 / 5.0m;
// int decimalQuotientB = 7.0m / 5;
// int decimalQuotientC = 7.0m / 5.0m;
// decimal decimalQuotientD = 7 / 5;

//e- Add code to cast results of integer division
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second; // cast operator 
Console.WriteLine(quotient);

//three uses for the parenthesis operator: method invocation, order of operations and casting.

//f- Write code to determine the remainder after integer division

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");
Console.WriteLine($"Modulus of 88 / 55 : {88 % 55}");

Console.Write("\n\n====================\n\n"); // Separator


//g- Write code for Number Power using the method Pow
Console.WriteLine(System.Math.Pow(12,2));

Console.Write("\n\n====================\n\n"); // Separator


//H- Increment and decrement values
// 1.compound assignment operator +=, -=, *=, ++, and --
int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;        // value is now 10.
value ++;
value --;
-- value ;
++ value;

/*
Complete the challenge to convert Fahrenheit to Celsius
Completed
100 XP
10 minutes
In this challenge, you'll write code that will use a formula to convert a temperature from degrees Fahrenheit to Celsius. You'll print the result in a formatted message to the user.

Challenge: Calculate Celsius given the current temperature in Fahrenheit
Select all of the code you wrote previously in the C# Code Editor and press Delete or Backspace to delete it.

Enter the following code in the C# Code Editor:

C#
int fahrenheit = 94;
To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32, then multiply by five ninths (5 / 9).

Display the result of the temperature conversion in a formatted message

Combine the variables with literal strings passed into a series of Console.WriteLine() commands to form the complete message.

When you're finished, the message should resemble the following output:

Output
The temperature is 34.444444444444444444444444447 Celsius.
 Note

Admittedly, it is preferred to not see so many values after the decimal point. Ideally the value would be formatted to a single value after the decimal point: 34.4.

Whether you get stuck and need to peek at the solution or you finish successfully, continue to view a solution to this challenge.


*/

int fahrenheit = 94;
decimal fiveNinths = (decimal)5 / 9 ; // must the answer be decimal and at least one number decimal
decimal celsius =(fahrenheit - 32) * fiveNinths ; // first we subtract => we use parentheses
Console.WriteLine(celsius);

Console.WriteLine($"Windows {1 + 1}");

Console.Write("Windows " + 1 + 1);