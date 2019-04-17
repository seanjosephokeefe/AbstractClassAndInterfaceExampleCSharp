using System;
using static System.Console;

namespace AbstractAndInterfaceClassExample
{
    public abstract class HelperClass
    {

        public static String GetString(String prompt)
        {
            String result = null;
            do
            {
                Write(prompt);
                result = ReadLine();
                if (String.IsNullOrEmpty(result))
                    result = null;
            } while (result == null);
            return result;
        }

        public static int GetInteger(String prompt)
        {
            int number = 0;
            bool valid = false;
            do
            {
                String input = GetString(prompt);
                if (int.TryParse(input, out number))
                {
                    valid = true;
                }
                else
                {
                    WriteLine("That is not a valid integer. Please try again.");
                }
            } while (valid == false);
            return number;
        }

        public static double GetDouble(String prompt)
        {
            double number = 0.0;
            bool valid = false;
            do
            {
                String input = GetString(prompt);
                if (double.TryParse(input, out number))
                {
                    valid = true;
                }
                else
                {
                    WriteLine("That is not a valid double. Please try again.");
                }
            } while (valid == false);
            return number;
        }

        public static Decimal GetDecimal(String prompt)
        {
            Decimal number = 0m;
            bool valid = false;
            do
            {
                String input = GetString(prompt);
                if (Decimal.TryParse(input, out number))
                {
                    valid = true;
                }
                else
                {
                    WriteLine("That is not a valid decimal. Please try again.");
                }
            } while (valid == false);
            return number;
        }

        public static char GetCharacter(String prompt)
        {
            return GetString(prompt).ToCharArray()[0];
        }

        public static void PromptUser(String prompt)
        {
            Write(prompt);
            ReadLine();
        }

        public static void PressAnyKey(String prompt)
        {
            Write(prompt);
            ReadKey();
        }

    }
}
