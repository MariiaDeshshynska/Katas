/*
Sum Strings as Numbers
Given the string representations of two integers, return the string representation of the sum of those integers.

For example:

sumStrings('1','2') // => '3'
A string representation of an integer will contain no characters besides the ten numerals "0" to "9".
*/
public static class Kata
{
        public static string sumStrings(string a, string b)
        {
                if(a.Length < 8 || b.Length < 8)
                {
                    int num1, num2;
                    int.TryParse(a, out num1);
                    int.TryParse(b, out num2);
                    return Convert.ToString(num1 + num2);
                }
                if (a.Length > 18 || b.Length > 18)
            {
                StringBuilder res1 = new StringBuilder(); 
                StringBuilder res2 = new StringBuilder();
                string resA = "";
                string resB = "";

                if (a.Length != b.Length)
                {
                    if(a.Length>b.Length)
                    {
                        
                        res2.Append(b);
                        for (int i = a.Length - b.Length; i > 0; i--)
                        {
                            res2.Insert(0, "0");
                        }
                        resB = Convert.ToString(res2);
                        resA = a;

                    }
                    if(b.Length > a.Length)
                    {
                        res1.Append(a);
                        for (int i = b.Length - a.Length; i > 0; i--)
                        {
                            res1.Insert(0, "0");
                        }
                        resA = Convert.ToString(res1);
                        resB = b;
                    }

                }
                  try{
                string str1 = resA.Substring(0,16);
                string str2 = resA.Substring(16);
                string str3 = resB.Substring(0,16);
                string str4 = resB.Substring(16);
                    
                
                ulong num1 = ulong.Parse(str2);
                ulong num2 = ulong.Parse(str4);
                ulong num3 = ulong.Parse(str1);
                ulong num4 = ulong.Parse(str3);
                return Convert.ToString(num3 + num4) +Convert.ToString(num1 + num2);
                    }
                  catch(ArgumentOutOfRangeException)
                    {
                ulong num1;
                    ulong.TryParse(a.Substring(0,17), out num1);
                ulong num2;
                    ulong.TryParse(b.Substring(0,17), out num2);
                    ulong num3;
                    ulong.TryParse(a.Substring(17), out num3);
                ulong num4;
                    ulong.TryParse(b.Substring(17), out num4);
                    return Convert.ToString(num1+num2)+Convert.ToString(num3+num4);
                  }
            }

                else
                {
                    ulong num1 = ulong.Parse(a);
                    ulong num2 = ulong.Parse(b);
                    return Convert.ToString(num1+num2);
                }
        }

        /*Adding Big Numbers
        We need to sum big numbers and we require your help.

Write a function that returns the sum of two numbers. The input numbers are strings and the function must return a string.

Example
add("123", "321"); -> "444"
add("11", "99");   -> "110"
Notes
The input numbers are big.
The input is a string of only digits
The numbers are positives
        */
        public static string Add(string a, string b)
  {
      BigInteger aInt;
      BigInteger bInt;
      
      BigInteger.TryParse(a, out aInt);
      BigInteger.TryParse(b, out bInt);
      
      return (aInt + bInt).ToString();
    }