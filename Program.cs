using System;
System.Console.Write("Enter the first number: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Choose one operation(+,-,*,/,%):");
string operation = Console.ReadLine();
System.Console.Write("Enter the second number: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

if(firstNumer>secondNumer)
{
  System.Console.WriteLine("First number is greater than the second one");
}
else if (firstNumer==secondNumer)
{
  System.Console.WriteLine("First number is equal to the second one");
}
else {
  System.Console.WriteLine("First number is less than the second one");
}
switch (operation)
{
    case "+" :
      System.Console.WriteLine($"{firstNumer} + {secondNumer} = {firstNumer + secondNumer}");
      break;

    case "-" :
      System.Console.WriteLine($"{firstNumer} - {secondNumer} = {firstNumer - secondNumer}");
      break;

      case "*" :
      System.Console.WriteLine($"{firstNumer} * {secondNumer} = {firstNumer * secondNumer}");
      break;

    case "/" :
      System.Console.WriteLine($"{firstNumer} / {secondNumer} = {firstNumer / secondNumer}");
      break;
      case "%" :
      System.Console.WriteLine($"{firstNumer} % {secondNumer} = {firstNumer % secondNumer}");
      break;
      default:
        System.Console.WriteLine("Operation not found!!!");
        break;
    
}