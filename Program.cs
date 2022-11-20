using System;
System.Console.Write("Enter the first number: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

string message =
  firstNumer>=0
    ? "First number is positive"
    :"First number is negative";


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

