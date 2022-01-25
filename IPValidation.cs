/*
IP Validation
Write an algorithm that will identify valid IPv4 addresses in dot-decimal format. IPs should be considered valid if they consist of four octets, with values between 0 and 255, inclusive.
*/
public static bool is_valid_IP(string ipAddres)
        {
            if (ipAddres is null || ipAddres == string.Empty || ipAddres.Contains("..") || ((ipAddres+" ").Contains(". "))|| ((" "+ipAddres).Contains(" ."))) return false;
           var str = ipAddres.Split(".");
            if (str.Length != 4) return false;
            foreach (var s in str)
            {
                foreach (var c in s)
                {
                    if (!char.IsDigit(c))
                    {
                        return false;
                    }
                }
                int num;
                int.TryParse(s, out num);
                if (num < 0 || num>255)
                {
                    return false;
                }
                if (s.StartsWith("0") && s.Length > 1) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(is_valid_IP("0.0.0.0"));
            Console.WriteLine(is_valid_IP("12.255.56.1"));
            Console.WriteLine(is_valid_IP("137.255.156.100"));

            Console.WriteLine(is_valid_IP(""));
            Console.WriteLine(is_valid_IP("abc.def.ghi.jkl"));
            Console.WriteLine(is_valid_IP("123.456.789.0"));
            Console.WriteLine(is_valid_IP("12.34.56"));
            Console.WriteLine(is_valid_IP("12.34.56.00"));
            Console.WriteLine(is_valid_IP("12.34.56.7.8"));
            Console.WriteLine(is_valid_IP("12.34.256.78"));
            Console.WriteLine(is_valid_IP("1234.34.56"));
            Console.WriteLine(is_valid_IP("pr12.34.56.78"));
            Console.WriteLine(is_valid_IP("12.34.56.78sf"));
            Console.WriteLine(is_valid_IP("12.34.56 .1"));
            Console.WriteLine(is_valid_IP("12.34.56.-1"));
            Console.WriteLine(is_valid_IP("123.045.067.089"));
        }       