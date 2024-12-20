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

    }
}