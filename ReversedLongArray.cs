/*Convert number to reversed array of digits
Convert number to reversed array of digits
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.
*/
        static long[] Digitize(long n)
        {
            string s = Convert.ToString(n);
            long[] arr = new long[] { };
            for (var i = (s.Length - 1); i != -1; i--)
            {
                arr = arr.Append((long)Char.GetNumericValue(s[i])).ToArray();
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Digitize(35231);
            Digitize(0);
        }