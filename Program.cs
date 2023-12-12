// Name: Elizabeth Trotter

// Date Revised: 9/8/2023 

// Exercise: Mini Challenge # 4 - Greater Than or Less Than

// Brief Description: Ask the user to enter in two numbers & print 2 statements.
// The first statement should tell me if the first number is greater than, less than or equal to the second number.
// The second statement should tell me if the second number is greater than, less than, or equal to the first number.

// Peer Reviewer: Brandon Nguyen, the code runs smoothly.

Console.Clear();

string title = "Mini Challenge # 4";
Console.WriteLine(title);
string breakPoint = "------------------------------------------------------------------";
Console.WriteLine(breakPoint);

Console.Write("Please enter a whole number between 0 and 999999999: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter another whole number between 0 and 999999999: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(breakPoint);

// First Statement

if( firstNum > secondNum ){
    Console.WriteLine($"{firstNum} is greater than {secondNum}.");
}else if( firstNum < secondNum ){
    Console.WriteLine($"{firstNum} is less than {secondNum}.");
}else{
    Console.WriteLine($"{firstNum} is equal to {secondNum}.");
}

// Second Statement

if( secondNum > firstNum ){
    Console.WriteLine($"{secondNum} is greater than {firstNum}.");
}else if( secondNum < firstNum ){
    Console.WriteLine($"{secondNum} is less than {firstNum}.");
}else{
    Console.WriteLine($"{secondNum} is equal to {firstNum}.");
}

Console.WriteLine(breakPoint);