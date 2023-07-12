using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first num :-");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the operations:-");
            string ope = Console.ReadLine();
            Console.WriteLine("enter the second num :-");
            float num2 = float.Parse(Console.ReadLine());
            operations opt = new operations();
            switch (ope)
            {
                case "+":
                    Console.WriteLine($"{num1} + {num2} = {opt.sum(num1,num2)}");
                    break;
                    
                case "-":
                    Console.WriteLine($"{num1} - {num2} = {opt.sub(num1, num2)}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} * {num2} = {opt.mul(num1, num2)}");
                    break;
                case "/":
                    Console.WriteLine($"{num1} / {num2} = {opt.div(num1, num2)}");
                    break;
                case "%":
                    Console.WriteLine($"{num1} % {num2} = {opt.rem(num1, num2)}");
                    break;
            }
            

        }

    }

    class operations
    {
        public float sum (float N1 , float N2)
        {
            return N1 + N2;
        }

        public float sub(float N1, float N2)
        {
            return N1 - N2;
        }

        public float mul(float N1, float N2)
        {
            return N1 * N2;
        }

        public float div(float N1, float N2)
        {
            return N1 / N2;
        }

        public float rem(float N1, float N2)
        {
            return N1 % N2;
        }
    }
}