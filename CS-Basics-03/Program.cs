using System.Xml.XPath;

namespace Cs_Basics;
internal class Program
{
     static void Main(string[] args)
    {
        #region 1.Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
        //Console.WriteLine("Enter a Number that can be divided by 3 and 4");
        //int Num = int.Parse(Console.ReadLine());
        //if(Num%3 == 0 && Num%4==0)
        //    Console.WriteLine("Yes");
        //else
        //    Console.WriteLine("No");
        #endregion
        #region 2.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
        //Console.WriteLine("Enter a Number");
        //int Num = int.Parse(Console.ReadLine());
        //if(Num >= 0 )
        //    Console.WriteLine("Positive");
        //else
        //    Console.WriteLine("Negative");

        #endregion
        #region 3.Write a program that takes 3 integers from the user then prints the max element and the min element.
        //Console.WriteLine("Enter the first number");

        //int num1 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the second number");

        //int num2 = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the third number");

        //int num3 = int.Parse(Console.ReadLine());

        //if(num1 > num2 && num1 > num3)
        //{
        //    Console.WriteLine($"Max element = {num1}");
        //    if(num2 > num3)
        //    {
        //        Console.WriteLine($"Min element = {num3}");
        //    }
        //    else
        //        Console.WriteLine($"Min element = {num2}");
        //}
        //else if(num2 > num1 && num2 > num3)
        //{
        //    Console.WriteLine($"Max element = {num2}");
        //    if (num1 > num3)
        //    {
        //        Console.WriteLine($"Min element = {num3}");
        //    }
        //    else
        //        Console.WriteLine($"Min element = {num1}");
        //}
        //else if (num3 > num1 && num3 > num2)
        //{
        //    Console.WriteLine($"Max element = {num3}");
        //    if (num1 > num2)
        //    {
        //        Console.WriteLine($"Min element = {num2}");
        //    }
        //    else
        //        Console.WriteLine($"Min element = {num1}");
        //}

        // Simpler solution:
        //int max = num1;
        //int min = num1;
        //if (num2 > max)
        //    max = num2;
        //if (num3 > max)
        //    max = num3;

        //if (num2 < min)
        //    min = num2;
        //if (num3 < min)
        //    min = num3;

        //Console.WriteLine($"Max element = {max}");
        //Console.WriteLine($"min element = {min}");

        #endregion
        #region 4.Write a program that allows the user to insert an integer number then check If a number is even or odd.
        //Console.WriteLine("enter a number");
        //int Num = int.Parse(Console.ReadLine());
        //if (Num % 2 == 0)
        //    Console.WriteLine($"{Num} is even");
        //else
        //    Console.WriteLine($"{Num} is Odd");

        #endregion
        #region 5.Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
        //Console.WriteLine("Enter a Letter");
        //string Letter = Console.ReadLine();
        //if(Letter.Length == 1)
        //{
        //    switch (Letter)
        //    {
        //        case "a":
        //        case "o":
        //        case "i":
        //        case "e":
        //        case "u":
        //            Console.WriteLine("Vowel");
        //            break;
        //        default:
        //            Console.WriteLine("Consonant");
        //            break;
        //    }
        //}
        //else
        //    Console.WriteLine("You entered more than one char");
      
        //Console.ReadKey();
        #endregion


    }
}