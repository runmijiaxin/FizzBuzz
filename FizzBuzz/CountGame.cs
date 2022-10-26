﻿using System;

namespace FizzBuzz
{
    public class CountGame
    {
        public string OrdMapping(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return "Fizz";
            }

            if (number % 3 == 0)
            {
                if (number % 5 == 0)
                {
                    if (number % 7 == 0)
                    {
                        return "FizzBuzzWhizz";
                    }

                    return "FizzBuzz";
                }

                if (number % 7 == 0)
                {
                    return "FizzWhizz";
                }

                return "Fizz";
            }

            if (number % 5 == 0)
            {
                if (number % 7 == 0)
                {
                    return "BuzzWhizz";
                }

                return "Buzz";
            }

            if (number % 7 == 0)
            {
                return "Whizz";
            }

            return number.ToString();
        }
    }
}
