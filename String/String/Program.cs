using System;

namespace TestString
{
	public class Program

	{
		public static void Main(string[] args)
		{
			string a = Console.ReadLine();
			Console.WriteLine(MaxAmountOfNumbers(a));

		}

        public static int MaxAmountOfDifferent(string x)
        {
            int amount = 0, maxAmount = 0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                if (x[i] != x[i + 1])
                { amount++; }
                else if (amount > maxAmount)
                {
                    maxAmount = amount + 1;
                    amount = 0;
                }
                else amount = 0;


            }
            if (amount > maxAmount)
                maxAmount = amount + 1;
            return maxAmount;


        }

        public static int MaxAmountOfNumbers(string x)
        {
            int amount = 1, maxAmount = 0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                if ((x[i] == x[i + 1]) && ('0' <= x[i]) && ('9' >= x[i]))
                { amount++; }
                else if (amount > maxAmount)
                {
                    maxAmount = amount;
                    amount = 1;
                }
                


            }
            if (amount > maxAmount)
                maxAmount = amount;
            return maxAmount;


        }

        public static int MaxAmountOfLetters(string x)
        {
            int amount = 0, maxAmount = 0;
            for (int i = 0; i < x.Length - 1; i++)
            {
                if ((x[i] == x[i + 1]) && ('a' <= x[i]) && ('z' >= x[i]))
                { amount++; }
                else if (amount >= maxAmount)
                {
                    maxAmount = amount + 1;
                    amount = 0;
                }
                else amount = 0;


            }
            if (amount > maxAmount)
                maxAmount = amount + 1;
            return maxAmount;


        }
    }
}