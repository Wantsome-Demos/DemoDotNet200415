namespace SimpleGameDemo
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random generator = new Random();
            int generatedNumber = generator.Next(10);

            for (int tryIdx = 1; tryIdx <= 3; tryIdx = tryIdx + 1)
            {
                Console.WriteLine("Introduceti numar");
                string input = Console.ReadLine();
                int userNumber = Convert.ToInt32(input);

                if (generatedNumber == userNumber)
                {
                    Console.WriteLine("Ati ghicit numar! Nr incercari " + tryIdx);
                    return;
                }

                if (generatedNumber > userNumber)
                {
                    Console.WriteLine("Nr mai mare! ");
                }
                else
                {
                    Console.WriteLine("Nr mai mic!");
                }
            }

            Console.WriteLine("Nu ati ghicit. Numarul este: " + generatedNumber);
        }
    }
}
