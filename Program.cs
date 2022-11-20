using System;
System.Console.Write("Enter the first number: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter the second number: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());
//and logical operator 
string message =
  firstNumer>=0 && secondNumer>=0
    ? "First and second numbers are  positive"
    : "First and/or second numbers are negative";
      System.Console.WriteLine(message);
//or logical operator 
string mesage =
  firstNumer>=0 || secondNumer>=0
    ? "First or second number is  positive"
    : "First and second numbers are negative";
      System.Console.WriteLine(mesage);
//not logical operator
string msg=
  !(firstNumer>=0)
    ? "First  number is not positive"
    : "First  number is not negative";
      System.Console.WriteLine(msg);
