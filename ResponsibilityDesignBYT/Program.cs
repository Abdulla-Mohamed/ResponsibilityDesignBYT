using System;
using ResponsibilityDesignBYT.Models;

namespace ResponsibilityDesignBYT
{
    class Program
    {
        static void Main(string[] args)
        {

        
        
          Chain c1 = new InvalidSign();
          Chain c2 = new AdditionCalculation();
          Chain c3 = new SubtractionCalculations();
          Chain c4 = new MultiplicationCalculation();
          Chain c5 = new DivisionCalculation();

            c1.setNext(c2);
            c2.setNext(c3);
            c3.setNext(c4);
            c4.setNext(c5);

            Calculation calculation1 = new Calculation(5, 5, "+");
            Calculation calculation2 = new Calculation(5, 5, "-");
            Calculation calculation3 = new Calculation(5, 5, "*");
            Calculation calculation4 = new Calculation(5, 5, "/");
            Calculation calculation5 = new Calculation(5, 5, "potato");

            Console.WriteLine(c1.calculate(calculation1).result);
            Console.WriteLine(c1.calculate(calculation2).result);
            Console.WriteLine(c1.calculate(calculation3).result);
            Console.WriteLine(c1.calculate(calculation4).result);
            Console.WriteLine(c1.calculate(calculation5).result);


        }

    }
}
