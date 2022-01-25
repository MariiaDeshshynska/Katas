/*
SumOfMinimums
Given a 2D ( nested ) list ( array, vector, .. ) of size m * n, 
your task is to find the sum of the minimum values in each row.
*/
public static int SumOfMinimums(int[,] numbers)
  {
    int sum = 0;
            int min =0;
            for (int k = 0; k < numbers.GetLength(0); k++)
            {
                for (int l = 0; l < numbers.GetLength(1); l++)
                {
                    if(l==0) min = numbers[k, l];
                    if(numbers[k,l]<min)
                    {
                        min = numbers[k, l];
                    }
                }
                sum += min;
            }
            return sum;
  }  
/*Roman Numerals Encoder
Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.*/
          public static string Solution(int n)
        {
            StringBuilder sb = new StringBuilder();

            while (n != 0)
            {
                if (n >= 1000)
                {
                    sb.Append("M");
                    n -= 1000;
                }
                if (n < 1000 && n >= 500)
                {
                    if (n >= 900)
                    {
                        sb.Append("CM");
                        n -= 900;
                    }
                    else
                    {
                        sb.Append("D");
                        n -= 500;
                    }
                }
                if (n < 500 && n >= 100)
                {
                    if (n >= 400)
                    {
                        sb.Append("CD");
                        n -= 400;
                    }
                    else
                    {
                        sb.Append("C");
                        n -= 100;
                    }
                }
                if (n < 100 && n >= 50)
                {
                    if (n >= 90)
                    {
                        sb.Append("XC");
                        n -= 90;
                    }
                    else
                    {
                        sb.Append("L");
                        n -= 50;
                    }
                }
                if (n < 50 && n >= 10)
                {
                    if (n >= 40)
                    {
                        sb.Append("XL");
                        n -= 40;
                    }
                    else
                    {
                        sb.Append("X");
                        n -= 10;
                    }
                }
                if (n < 10 && n >= 5)
                {
                    if (n == 9)
                    {
                        sb.Append("IX");
                        n -= 9;
                    }
                    else
                    {
                        sb.Append("V");
                        n -= 5;
                    }
                }
                if (n < 5 && n >= 1)
                {
                    if (n == 4)
                    {
                        sb.Append("IV");
                        n -= 4;
                    }
                    else
                    {
                        sb.Append("I");
                        n -= 1;
                    }
                }
            }
            return Convert.ToString(sb);
        }