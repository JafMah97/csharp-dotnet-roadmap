// ------------------ Character Escape Sequences ------------------ //

 //  1- \n => new Line
Console.Write("Hello World!\n"); // here we add another line after we print "Hello World!"
Console.Write("Hi From another line"); // this will Print in New Line

Console.Write("\n"); // this will Just Jump to the Next Line , without printing anything
Console.Write("\n\n====================\n\n"); // Separator

// 2- \t => tab : (four spaces)
Console.Write("Hello\tWorld!"); // here we print the "Hello    World!" four spaces => 1 Tab 

Console.Write("\n\n====================\n\n"); // Separator

// 3- \' or \" : escape single or double quotation
Console.Write("Hello \'World\'!\n");
Console.Write("Hello \"World\"!");

Console.Write("\n\n====================\n\n"); // Separator

// 4- escape back-slash
Console.Write("C:\\source\\repos");

Console.Write("\n\n====================\n\n"); // Separator


/*

        *********** TASK ***********
        Make the Output :
        Generating invoices for customer "Contoso Corp" ...

        Invoice: 1021           Complete!
        Invoice: 1022           Complete!

        Output Directory:  

*/

Console.Write("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.Write("\n");
Console.Write("Invoice: 1021\t\t\tComplete!\n");
Console.Write("Invoice: 1022\t\t\tComplete!\n");
Console.Write("\n");
Console.Write("Output Directory: \n");

Console.Write("\n\n====================\n\n"); // Separator



/* ================= Verbatim string literal ================= */

// we use the @ directive before the literal string

Console.Write(@"                      c:\source\repos no need to character escape sequence ' \ \t \n 
this will print in New line 
");

// we use two double quotation inside the verbatim to print single double quotation
Console.WriteLine(@"this is ""Double quotation""");


Console.Write("\n\n====================\n\n"); // Separator



// ------------------ Unicode escape characters ------------------ //

/* 
first what is Unicode escape characters ?
  it is the way we Create and print chars that are not inside the keyboards key

why we need to do that ?
  1. Just for better UI       : Maybe we want to add an emoji without the need to copy paste it .
  2. file Encoding            : When we save a file that have a special chars on a system , and reopen it on a different system that does not support the same encoding system => the text will be different .
  3. represent unseen chars   : like unbreakable space (the space has the same shape of the normal space, but prevent the text from wrapping into new line .) here we use the unicode escape for that \u00A0
  4. support localization     : Like Arabic or Japanese languages  

some examples:

1. no break space             : u00A0
2. inverted exclamation mark  : u00A1
3. copy right sign            : u00A9
4. DEGREE SIGN                : u00B0

You can Read more about this in link: https://gist.github.com/ivandrofly/0fe20773bd712b303f78
*/


Console.WriteLine("All rights Reserved \u00A9"); // copy right shape

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");



Console.Write("\n\n====================\n\n"); // Separator


// ------------------  Combine strings using string concatenation ------------------ //

// what is concatenation ? simply combine two or more strings

//1.Concatenate a literal string and a variable

var firstName = "Bob" ;
Console.WriteLine(firstName + " Joe");

//2.Concatenate multiple variables and literal strings
var lastName = "Joe";

Console.WriteLine("Hello "+firstName+" "+lastName+" !");

Console.Write("\n\n====================\n\n"); // Separator

// ------------------  Combine strings using string interpolation ------------------ //

// what is string Interpolation ? string interpolation combine multi values into single literal string by using "Template" and one or more interpolation expressions
// open and close curly braces {}, and the literal string must be prefixed with the dollar sign

var userAge = 45;
var userName = "@username";
var userJob = "Developer";

Console.WriteLine($"Hello {userName} , your age is : {userAge} ,  and your Job is : {userJob} .");

var projectName1 = "myAwesomeProject";
var locationOnDesk = $@"c:\users\theUserName\projects\{projectName1}";

Console.WriteLine("the Project Location is : " + locationOnDesk);

Console.Write("\n\n====================\n\n"); // Separator


/*

Complete the challenge
Completed
100 XP
10 minutes
Code challenges will reinforce what you've learned and help you gain some confidence before continuing on.

In this challenge, you'll print instructions to the end user to let them know where your application will output data files. You won't be actually creating any files -- you're only interested in displaying formatted instructions to the console window.

You'll use what you've learned about character escape sequences, verbatim strings, unicode, and string interpolation to provide instructions in both English and Russian.

Challenge: Format and display instructions
Select all of the code you wrote previously in the C# Code Editor, and press Delete or Backspace to delete it.

Begin solving the challenge with the following two lines of code.

C#
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
The projectName variable will be used twice in the desired output.

The russianMessage variable contains the message "View Russian output" in Russian. You must use this variable in your code that prints the message.

You may not change these two lines of code, but you can add code above and below each line. You must use these two lines of code to form the desired output.

You may only use either the Console.WriteLine() or the Console.Write() method twice.
In other words, to complete this challenge, you can only create two instructions that actually print output to the console. If you need to print additional new lines or add any formatting, you must use what you've learned in this module to accomplish it.

Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.
To complete this challenge, your code must produce the following output.

Output
View English output:
  c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
  c:\Exercise\ACME\ru-RU\data.txt

Take note of the new lines, the tabs, and how the two mandatory lines of code are used in the output.

Whether you get stuck and need to peek at the solution, or you finish successfully, continue on to view a solution to this challenge.

*/
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine(@$"View English output:
c:\Exercise\{projectName}\data.txt
");
Console.WriteLine(@$"{russianMessage}
c:\Exercise\{projectName}\ru-RU\data.txt
");