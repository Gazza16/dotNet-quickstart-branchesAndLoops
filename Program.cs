using System;

namespace BranchesAndLoops
{
    class Program
    {

      static void IfStatements()
      {
        int a = 2;
        int b = 4;
          if (a + b > 10)
          {
              Console.WriteLine("The answer is greater than 10.");
          }
          else
          {
              Console.WriteLine("The answer is not greater than 10");
          }

        int c = 8;
          if ((a + b + c > 10) && (a > b))
          {
          Console.WriteLine("The answer is greater than 10");
          Console.WriteLine("And the first number is greater than the second");
          }
          else
          {
          Console.WriteLine("The answer is not greater than 10");
          Console.WriteLine("Or the first number is not greater than the second");
}

          if ((a + b + c > 10) || (a > b))
        {
            Console.WriteLine("The answer is greater than 10");
            Console.WriteLine("Or the first number is greater than the second");
        }
        else
        {
            Console.WriteLine("The answer is not greater than 10");
            Console.WriteLine("And the first number is not greater than the second");
        }
      }

      static void IfStatementsAndLoops()
      {
        int counter = 0;
        while (counter < 10)
        {
          Console.WriteLine($"Hello world! The counter is less than {counter}");
          counter++;
        }

        counter = 0;
        do
        {
            Console.WriteLine($"Hello World! The counter is {counter}");
            counter++;
        } while (counter < 10);

          for(int gas = 0; gas < 10; gas++)
    {
        Console.WriteLine($"Hello World! The index is {gas}");
    }

      }

        static void Main(string[] args)
        {
            IfStatements();

            IfStatementsAndLoops();


      }
 }
}
