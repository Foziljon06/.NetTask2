// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello first commite");

//int num1 = 10;
// int num2 = 12;

// if (num1 > num2 && num1>= 0){
//     Console.WriteLine($"{num1} is biggest");

// }

// else
// {
//     Console.WriteLine($"{num2 } is bigeest");
// }

//                     LOGICAL OPERATORS


// String result = num1>0 && num1!<10 
// ? " this is true"
// : " this is not true";     
// Console.WriteLine(result);

//                     Switch case

Console.WriteLine("Enter 1st number ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter operation ( + ,  - ,  * , / ) : ");
string? operation = Console.ReadLine();

Console.WriteLine("Enter 2st number ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

switch(operation)
{
case "+":
Console.WriteLine($"{firstNumber}  +  {secondNumber}  =  { firstNumber + secondNumber}");
break;

case "-":
Console.WriteLine($"{firstNumber}  -  {secondNumber}  =  { firstNumber - secondNumber}");
break;

case "*":
Console.WriteLine($"{firstNumber}  *  {secondNumber}  =  { firstNumber * secondNumber}");
break;

case "/":
Console.WriteLine($"{firstNumber}  /  {secondNumber}  =  { firstNumber / secondNumber}");
break;

default:
Console.WriteLine("Operation not found");
break;
}

