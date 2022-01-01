using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            {
                int sum = 0;
                foreach (int i in numbers)

                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                        sum -= i;
                }

                return sum;
            }

             
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int Shortest = 0;
            if (str1.Length > Shortest)
            {
                Shortest = str1.Length;

                if (str2.Length < Shortest)
                {
                    Shortest = str2.Length;
                }
                if (str3.Length < Shortest)
                {
                    Shortest = str3.Length;
                }
                if (str4.Length < Shortest)
                {
                    Shortest = str4.Length;
                }

            }
            return Shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int SmallestNum = Int32.MinValue;
            if (number1 > SmallestNum)
            {
                SmallestNum = number1;

                if (number2 < SmallestNum)
                {
                    SmallestNum = number2;
                }
                if (number3 < SmallestNum)
                {
                    SmallestNum = number3;
                }
                if (number4 < SmallestNum)
                {
                    SmallestNum = number4;
                }
            }
            return SmallestNum;
        }


             public void ChangeBusinessNameTo_TrueCoders(Business biz)
             {
                biz.Name = "TrueCoders";
             }


             public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
                {
           
            
                if (sideLength1 + sideLength2 > sideLength3
                    && sideLength1 + sideLength3 > sideLength2
                    && sideLength2 + sideLength3 > sideLength1)
                {
                    return true;
                }
                return false;
            
             }





        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
            
        }


        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var Majority = (amount / 2) + 1;
            var count = 0;
            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }

            if (count >= Majority)
            {
                return true;
            }
            else
            {
                return false;

            }

        }



            public double AverageEvens(int[] numbers)
            {
                if (numbers == null || numbers.Length == 0)
                {
                    return 0;
                }

                int evenSum = 0;
                int evenCount = 0;
                foreach (int i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        evenSum += i;
                        evenCount++;
                    }
                }
                if (evenCount == 0)
                {
                    return 0;
                }
                return (double)evenSum / evenCount;
            }


        public int Factorial(int number)
        {
            int i;
            int fact = 1;
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            return fact;


        }

    }
}
