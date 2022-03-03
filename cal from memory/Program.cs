using System;

namespace cal_from_memory
{
    class Program
    {
        public static void TheSwitch(int realNum1, string opo, int realNum2)
        {
            switch (opo)
            {
                case "+":
                    Console.WriteLine(realNum1 + realNum2);
                    break;

                case "-":
                    Console.WriteLine(realNum1 - realNum2);
                    break;

                case "*":
                    Console.WriteLine(realNum1 * realNum2);
                    break;

                case "/":
                    Console.WriteLine(realNum1 / realNum2);
                    break;

                case "^":
                    Console.WriteLine(Math.Pow(realNum1, realNum2));
                    break;

                case "%":
                    Console.WriteLine(realNum1 % realNum2);
                    break;
                default:
                    Console.WriteLine("Operator is Invalid");
                    return;
            }

            Success();
        }

        static void Success()
        {
            Console.WriteLine("Success! Pipeline");
        }

    /*try*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string num1 = Console.ReadLine();
            int realNum1 = Convert.ToInt32(num1);

            Console.WriteLine("Give me an operater for maths");
            string opo = Console.ReadLine();

            Console.WriteLine("Enter a number");
            string num2 = Console.ReadLine();
            int realNum2 = Convert.ToInt32(num2);

            TheSwitch(realNum1, opo, realNum2);
        }
       
        

    /*catch (DivideByZeroException e)
            {
            Console.WriteLine(e.Message);
            }*/
    }
        
}
