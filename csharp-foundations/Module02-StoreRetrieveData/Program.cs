Console.WriteLine('A');
Console.WriteLine(123);
Console.WriteLine("Hi There");
Console.WriteLine(0.123F);
Console.WriteLine(2.4435);
Console.WriteLine(2.9876543M);
Console.WriteLine(true);
Console.WriteLine(false);


string firstName;
firstName = "Bob";

Console.WriteLine(firstName);

string lastName = "Joe";
Console.WriteLine(lastName);

int userAge = 23;
Console.WriteLine(userAge);

int userJobTitle  ; // warning: The variable 'userJobTitle' is declared but never used

//userJobTitle = "Programmer";  //this is an error :Cannot implicitly convert type 'string' to 'int'

// Console.Write(userJobTitle);

int userWorkHours;

userWorkHours = 100;
Console.WriteLine(userWorkHours); // read the First value

userWorkHours = 20;
Console.WriteLine(userWorkHours); // read the second value

// string userEmail;

// Console.WriteLine(userEmail); // error :Use of unassigned local variable 'userEmail'



//Complete the challenge
// Completed
// 100 XP
// 6 minutes
// In this challenge, you'll write code that will combine literal and variable values into a single message.

// Challenge: Display literal and variable values
// Select all of the code you wrote previously in the C# Code Editor then select the Delete or Backspace key to delete it.

// Store the following values in variables:

// Bob
// 3
// 34.4
// These variables should be given names that reflect their purpose.

// Make sure you select the correct data type for each of the variables based on the type of data it will hold.

// Finally, you'll combine the variables with literal strings passed into a series of Console.Write() commands to form a complete message.

// Write code in the C# Code Editor to display the following message:

// Output
// Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.
// No matter how you do it, your code should produce the specified output.

// Whether you get stuck and need to peek at the solution or you finish successfully, continue to view a solution to this challenge.

string customerName = "Bob";
int newMessages= 3;
double dayTemperature = 34.4;


Console.Write("Hello, ");
Console.Write(customerName);
Console.Write("! You have ");
Console.Write(newMessages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(dayTemperature);
Console.WriteLine(" celsius.");
Console.WriteLine(34.40M);
Console.WriteLine(34.40);
Console.WriteLine(34.40F);