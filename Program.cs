using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppParameters
{
    // =================example of value==================
    //    public class Calc
    //    {
    //        public void Increment(int num) 
    //        {
    //            Console.WriteLine("Value of num inside Method before increment:\t"+num);
    //            num += 5;
    //            Console.WriteLine("Value of num inside Method after increment:\t"+num);

    //        }
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            int myNum;
    //            Console.WriteLine("Enter a Number");
    //            myNum=int.Parse(Console.ReadLine());
    //            Console.WriteLine("myNum in Main befor Method call is:\t" + myNum);
    //            Calc calc= new Calc();
    //            calc.Increment(myNum);
    //            Console.WriteLine("myNum in Main after Method call is :\t" + myNum);

    //            Console.ReadKey();
    //        }
    //    }
    //}


    //=======================Example of ref=======================
    //    public class Calc
    //    {
    //        public void BonusCalc(double salary,ref double bonus)
    //        {
    //            bonus = salary*0.2;

    //        }
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            double salary = 50000;
    //            double bonus = 500;
    //            Calc calc = new Calc();
    //            calc.BonusCalc(salary, ref bonus);
    //            Console.WriteLine($"Salary: {salary} and Bonus: {bonus}");

    //            Console.ReadKey();
    //        }
    //    }
    //}

    // ==============Example of out ===============================

    //    public class Calc
    //    {
    //        public void BonusCalc(double salary, out double bonus)
    //        {
    //            bonus = salary * 0.2;

    //        }
    //    }
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            double salary = 50000;
    //            double bonus;
    //            Calc calc = new Calc();
    //            calc.BonusCalc(salary, out bonus);
    //            Console.WriteLine($"Salary: {salary} and Bonus: {bonus}");

    //            Console.ReadKey();
    //        }
    //    }
    //}

    // =======================Example of params=====================
    public class Calc
    {
        public double Add(params double[] numbers)
        {
            double total = 0;
            foreach (double number in numbers)
            {
                total += number;
            }
            return total;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("Result after adding 1,12,23.5 is=\t"+calc.Add(1,12,23.5));
            Console.WriteLine("Result after adding 10,12 is =\t"+calc.Add(10,12));
            Console.ReadKey();
        }
    }
}