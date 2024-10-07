using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number (0 - 999): ");
        int number = Int32.Parse(Console.ReadLine());

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Out of ability");
        }
        else
        {
            Console.WriteLine(NumberToWords(number));
        }
    }

    static string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        if (number < 10)
            return OneDigitToWords(number);

        if (number < 20)
            return TeenToWords(number);

        if (number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;
            return TensToWords(tens) + (ones > 0 ? " " + OneDigitToWords(ones) : "");
        }

        // Số có 3 chữ số
        int hundreds = number / 100;
        int remainder = number % 100;

        return OneDigitToWords(hundreds) + " hundred" + (remainder > 0 ? " and " + NumberToWords(remainder) : "");
    }

    static string OneDigitToWords(int number)
    {
        switch (number)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }

    static string TeenToWords(int number)
    {
        switch (number)
        {
            case 10: return "ten";
            case 11: return "eleven";
            case 12: return "twelve";
            case 13: return "thirteen";
            case 14: return "fourteen";
            case 15: return "fifteen";
            case 16: return "sixteen";
            case 17: return "seventeen";
            case 18: return "eighteen";
            case 19: return "nineteen";
            default: return "";
        }
    }

    static string TensToWords(int number)
    {
        switch (number)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
}

