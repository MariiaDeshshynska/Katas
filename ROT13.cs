/*
ROT13
How can you tell an extrovert from an introvert at NSA? Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.
Hint: For this task you're only supposed to substitue characters. Not spaces, punctuation, numbers etc. 
*/
public static string Rot13(string input)
        {
            StringBuilder list = new StringBuilder();

            foreach (var i in input)
            {
                if (!char.IsLetter(i))
                    list.Append(i);
                else
                {
                    char offset = char.IsUpper(i) ? 'A' : 'a';
                    list.Append((char)((((i + 13) - offset) % 26) + offset));
                }
            }
            return Convert.ToString(list);
        }