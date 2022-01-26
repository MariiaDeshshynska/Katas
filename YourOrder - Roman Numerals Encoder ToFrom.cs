/*
Your order, please
Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
*/
        public static string Order(string words)
        {
            string[] strArray = words.Split(" ");
            foreach (var h in strArray)
            {
                Console.WriteLine(h);
            }
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < strArray.Length+1; i++)
            {
                for (int j = 0; j < strArray.Length; j++)
                {
                    if (strArray[j].Contains(Convert.ToString(i)))
                    {
                        if(i== strArray.Length) newStr.Append(strArray[j] );
                        else newStr.Append(strArray[j] + " "); 
                    }
                }
            }
            
            return Convert.ToString(newStr);
        }

/*
Roman Numerals Helper
Create a RomanNumerals class that can convert a roman numeral to and from an integer value. It should follow the API demonstrated in the examples below. Multiple roman numeral values will be tested for each helper method.
Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.
*/
   using System;
using System.Text;
public class RomanNumerals
{
    public static string ToRoman(int n)
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

    public static int FromRoman(string romanNumeral)
    {
        romanNumeral += " ";
            int n = 0;
            for(int i=0; i< romanNumeral.Length; i++)
            {
                if (romanNumeral[i] == Convert.ToChar("M")) n += 1000;
                else if (romanNumeral[i] == Convert.ToChar("C") && romanNumeral[i + 1] == Convert.ToChar("M"))
                {
                    n += 900;
                    i++;
                }
                else if (romanNumeral[i] == Convert.ToChar("D")) { n += 500; }
            else if ((romanNumeral[i] == Convert.ToChar("C") && romanNumeral[i + 1] == Convert.ToChar("D")))
                    {
                    n += 400;
                    i++;
                }
                else if (romanNumeral[i] == Convert.ToChar("C")) { n += 100; }
                else if ((romanNumeral[i] == Convert.ToChar("X") && romanNumeral[i + 1] == Convert.ToChar("C")))
                    {
                    n += 90;
                    i++;
                }
                else if (romanNumeral[i] == Convert.ToChar("L")) { n += 50; }
                else if ((romanNumeral[i] == Convert.ToChar("X") && romanNumeral[i + 1] == Convert.ToChar("L")))
                    {
                    n += 40;
                    i++;
                }
                else if (romanNumeral[i] == Convert.ToChar("X")) { n += 10; }
                else if ((romanNumeral[i] == Convert.ToChar("I") && romanNumeral[i + 1] == Convert.ToChar("X")))
                {
                    n += 9;
                    i++;
                }
                else if (romanNumeral[i] == Convert.ToChar("V")) { n += 5; }
                else if ((romanNumeral[i] == Convert.ToChar("I") && romanNumeral[i + 1] == Convert.ToChar("V")))
                {
                    n += 4;
                    i++;
                }
                else if (romanNumeral[i] == Convert.ToChar("I")) { n += 1; }
            }
            return n;
    }
  }