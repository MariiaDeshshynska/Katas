/*
Counting Change Combinations
Write a function that counts how many different ways you can make change for an amount of money, given an array of coin denominations. For example, there are 3 ways to give change for 4 if you have coins with denomination 1 and 2:

1+1+1+1, 1+1+2, 2+2.
The order of coins does not matter:

1+1+2 == 2+1+1
Also, assume that you have an infinite amount of coins.

Your function should take an amount to change and an array of unique denominations for the coins:

  CountCombinations(4, new[] {1,2}) // => 3
  CountCombinations(10, new[] {5,2,3}) // => 4
  CountCombinations(11, new[] {5,7}) //  => 0
*/
public static int CountCombinations(int money, int[] coins)
        {
            int [] variants = new int [money + 1];
            variants[0] = 1;
            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 0; j < variants.Length; j++)
                {
                    if (coins[i] <= j)
                    {
                        variants[j] += variants[j - coins[i]];
                    }
                }
            }
            return variants[money];
        }