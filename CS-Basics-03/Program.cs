using System.Xml.XPath;

namespace Cs_Basics;
internal class Program
{
     static void Main(string[] args)
    {
        #region Value type Casting
        #region Implicit Casting
        //int X = 4; // 4 byte
        //long Y = /*(long)*/ X;
        #endregion

        #region Explict Casting
        //long X = 35234324234234; // 8 byte
        //int Y;
        //checked
        //{
        //    Y = (int)X;
        //}
        //Console.WriteLine(Y);

        //int x = 88;
        //double y = /*(double)*/x;

        //double x = 88.8;
        //int y =(int) x;
        //Console.WriteLine(y);
        #endregion

        #region Parse [Convert from string to any datatype]
        //int Number = int.Parse(Console.ReadLine());

        //Console.WriteLine("Enter Data USer");

        //Console.Write("Enter Name : ");
        //String Name = Console.ReadLine();

        //Console.Write("Enter Age : ");
        //int Age = int.Parse(Console.ReadLine());

        //Console.Write("Enter Salary : ");
        //double Salary = double.Parse(Console.ReadLine());

        //Console.Clear();
        //Console.WriteLine("Name : "+Name+" Age : "+Age+" Salary : "+Salary);

        #endregion
        #region Convert [Convert from any datatype to any datatype]
        //Console.WriteLine("Enter Data USer");

        //Console.Write("Enter Name : ");
        //String Name = Console.ReadLine();

        //Console.Write("Enter Age : ");
        //int Age = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter Salary : ");
        //double Salary = Convert.ToDouble(Console.ReadLine());

        //Console.Clear();
        //Console.WriteLine("Name : " + Name + " Age : " + Age + " Salary : " + Salary);
        #endregion
        #endregion
        #region Operators

        #region Unary Operators [++,--]
        //int X = 5;
        //X++;
        //++X;
        //Console.WriteLine(++X);
        //Console.WriteLine(X);

        //Console.WriteLine(--X);
        //Console.WriteLine(X--);
        //Console.WriteLine(X);
        #endregion

        #region Binary Operator
        //int Sum, Mul, Sub, Div, Mod;
        //int A = 8;
        //int B = 5;

        //Sum = A + B; // 13
        //Sub = A - B; // 3
        //Div = A / B; // 1
        //Mul = A * B; // 40
        //Console.WriteLine(Sum);
        #endregion
        #region Assignment Operator
        //int X = 10;
        //X += 10;
        //X -= 10;
        //X *= 10;
        //X /= 10;
        //X %= 10;

        #endregion
        #region Relational Operator
        //int A = 5;
        //int B = 10;
        //Console.WriteLine(A<B);

        #endregion
        #region Logical Operator [short circuit]
        //Console.WriteLine(!true);

        //Console.WriteLine(true && false);
        // true && true => true
        // true && false => false
        // false && true => false
        // false && false => false

        //Console.WriteLine(true || false);
        // true || true => true
        // true || false => true
        // false || true => true
        // false || false => false
        #endregion

        #region Bitwise operators [long circuit]
        //Console.WriteLine(true & false);
        // true & true => true
        // true & false => false
        // false & true => false
        // false & false => false

        //Console.WriteLine(true | false);
        // true | true => true
        // true | false => true
        // false | true => true
        // false | false => false
        #endregion
        #region Ternary operator [Conditional operator]

        //int X = 4;
        //String message = X > 4 ? "X is greater than 4" : "X less than or equal 4";
        //Console.WriteLine(message);

        #endregion
        #endregion
        #region Operator priority
        /*
         1. Unary Operator [prefix]
         2. ()
         3. * / %
         4. + -
         */

        //int A = 20;
        //int B = 15;
        //int C = 10;
        //int D = 5;
        //int result;

        //result = (A + B) * C / D;
        //result = ++A * C;
        //result = A * C;
        //Console.WriteLine(result);

        #endregion
        #region String Formating
        // Equation = X+Y = result
        // Equation = 10 + 5  = 15

        //int X = 5;
        //int Y = 10;
        //int result = X + Y;
        //Console.WriteLine("Equation : " + X+" + "+Y+" = "+result);
        // String => Immutable Datatype
        // string Name = "Ahmed";
        // Name = "Ali";

        #region 1. Composite Format
        //string Message = string.Format("Equation : {0} + {1} = {2}", X, Y, result);
        //Console.WriteLine(Message);

        //Console.WriteLine("Equation : {0} + {1} = {2}", X, Y, result);

        #endregion

        #region String Manipulition
        // String INterpulation => $
        //Console.WriteLine($"Equation : {X} + {Y} = {result}");
        #endregion
        #endregion
        #region If Else - Switch Case
        //Console.WriteLine("Enter Month Number");
        //int MonthNum = int.Parse(Console.ReadLine());
        // 1=> month is Jan
        // 2=> month is Feb
        // 3=> month is Mar
        // Invalid Input


        //if(MonthNum == 1)
        //{
        //    Console.WriteLine("month is Jan");
        //}
        //else if(MonthNum == 2)
        //{
        //    Console.WriteLine("month is Feb");

        //} else if(MonthNum == 3)
        //{
        //    Console.WriteLine("month is Mar");

        //}
        //else
        //{
        //    Console.WriteLine("Invalid input");

        //}

        //switch(MonthNum)
        //{
        //    case 1:
        //        Console.WriteLine("month is Jan");
        //        break;
        //    case 2:
        //        Console.WriteLine("month is Mar");
        //        break;
        //    case 3:
        //        Console.WriteLine("month is Mar");
        //        break;
        //    default:
        //        Console.WriteLine("Invalid input");
        //        break;
        //}

        //Console.WriteLine("Enter Name");
        //string Name = Console.ReadLine();

        //if(Name == "Mostafa")
        //{
        //    Console.WriteLine("Hello Mostafa");
        //}
        //else if(Name == "Aliaa")
        //{
        //    Console.WriteLine("Hello Mostafa");
        //} else if(Name == "Ahmed")
        //{
        //    Console.WriteLine("Hello Ahmed");
        //}

        //switch(Name)
        //{
        //    case "Mostafa":
        //        Console.WriteLine("Hello Mostafa");
        //        break;
        //    case "Aliaa":
        //        Console.WriteLine("Hello Aliaa");
        //        break;
        //    case "Ahmed":
        //        Console.WriteLine("Hello Ahmed");
        //        break;
        //}

        #endregion
        #region GoTo
        //Console.WriteLine("Enter Option");
        // 3000 => "Option 1" ,  "Option 2", "Option 3"
        // 2000 => "Option 1" ,  "Option 2"
        // 1000 => "Option 1" 

        //int option = int.Parse(Console.ReadLine());

        //switch(option)
        //{
        //    case 3000:
        //        Console.WriteLine("option 3");
        //        goto case 2000;
        //    case 2000:
        //        Console.WriteLine("option 2");
        //        goto case 1000;
        //    case 1000:
        //        Console.WriteLine("option 1");
        //        break;
        //}
        #endregion
    }
}