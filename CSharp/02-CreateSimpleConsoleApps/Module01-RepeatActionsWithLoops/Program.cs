// /*==========================================================*/
// /*==========================================================*/
// /*==========================================================*/
// /*=================== Learn Loops inside C# ================*/
// /*==========================================================*/
// /*==========================================================*/

// // 1- FOR loop syntax and usage : we use it when we need to repeat an action a known number of times


// // printing the numbers from 1 to 100

// for (int counter = 1 ; counter <= 100 ; counter++)
// {
//   Console.WriteLine($"{counter}");
// }

// // ===========================================
// Console.WriteLine("=================================="); //separator
// // ===========================================

// // 2- WHILE loop syntax and usage : 
// //we use the while loop when we need to repeat an action as long as a condition remains True

// int health = 10;

// while (health > 0)
// {
//   Console.WriteLine($"Your Player health is : {health}");
//   health--;
// }
// // always avoid infinite loop inside the while and do-while loop by changing the condition to be false eventually 
// // so the loop can stop


// // ===========================================
// Console.WriteLine("=================================="); //separator
// // ===========================================



// //3- The DO WHILE loop syntax and usage : we use it when we need the loop body to execute at least one time
// // no matter what is the condition for the loop

// // Ex -1

// int attempts = 3;
// do
// {
//   Console.WriteLine($"You have {attempts} Left");
//   attempts -- ;
// }
// while (attempts > 0);


// // ===========================================
// Console.WriteLine("=================================="); //separator
// // ===========================================


// int newAttempts = 0;
// do
// {
//   Console.WriteLine($"You have {newAttempts} Left"); // this will learn at least one 
//   newAttempts -- ;
// }
// while (newAttempts > 0);



// // ===========================================
// Console.WriteLine("=================================="); //separator
// // ===========================================

// // Controlling loop execution with Continue and Break

// // 1- break

// for (int count = 0; count < 10 ; count++)
// {
//   if (count == 5)
//   {
//     break ;
//   }
//   Console.WriteLine(count); // prints :0 -> 4 without 5 
// }
// // ===========================================
// Console.WriteLine("=================================="); //separator
// // ===========================================

// // 1- continue

// for (int count = 0; count < 10 ; count++)
// {
//   if (count == 5)
//   {
//     continue ;
//   }
//   Console.WriteLine(count); // skip the 5
// }

// // ===========================================
// Console.WriteLine("=================================="); //separator
// // ===========================================


// // user input 

// while(true){
//   Console.WriteLine(@"Please Type 'Exit' to exit the loop");
//   var x = Console.ReadLine();
//   if( x == "exit")
//   {
//     break;
//   };
// }

// 

// Guess the Number Game - v2

Random randomNumber = new();


Console.WriteLine("=====================================================");
Console.WriteLine("======= Welcome to Guess the number Game - V2 =======\n");
Console.WriteLine("\t*- Guess a Number between 0 and 100 , You have 7 tries,\n\t*- each time the Game will till you if the Number you guessed is higher or lower, \n\n\t\t Good Luck!.\n");
Console.WriteLine(@"enter 'exit' to quit the game at any time");
Console.WriteLine("=====================================================");

int secretNumber = randomNumber.Next(0, 101); // numbers between 0 - 100
int maxNumberOfGuesses = 7;
int guessesCount = 0;


while (true)
{
  //1- read the user input safely
Console.Write("Type your Guess : ");
var userInput = Console.ReadLine();

var isUserInputNullOrEmpty = string.IsNullOrWhiteSpace(userInput); // not white spaces or null or empty

//2- check if the user wants to exit the game
if (userInput?.Trim().ToLower() == "exit")
{
  Console.WriteLine("Exiting the game!.");
  break;
}


if (!isUserInputNullOrEmpty)
{
  // try to convert the user input into number
  var isInt = int.TryParse(userInput?.Trim(), out int res);
  if (isInt)
  {
    // check if the boundaries are correct
    if (res < 101 && res >= 0)
    {
      if (res == secretNumber)
      {
        Console.WriteLine(@$"Congrats , You've guessed the right number : {secretNumber} !!.");
        break;
      }
      else
      {
        guessesCount++;

        if (guessesCount == maxNumberOfGuesses)
        {
          Console.WriteLine($"You have hit the guesses limits , Game Over !");
          Console.WriteLine($"Better luck next time , the number was {secretNumber}");
          break;
        }
        
        if (res < secretNumber)
        {
          Console.WriteLine($"Try higher !,You still have {maxNumberOfGuesses - guessesCount} guesses");
        } else
        {
          Console.WriteLine($"Try lower !,You still have {maxNumberOfGuesses - guessesCount} guesses");
        }

      }
    }
    else
    {
      Console.WriteLine("The value must be between 0 and 100 !!,Please Try again");
    }
    ;
  }
  else
  {
    Console.WriteLine("The value you entered is not a number ,Please try again !!.");
    continue;
  }
}
else
{
  Console.WriteLine("The value you entered is not a valid data ,Please try again!! ");
  continue;
}
}