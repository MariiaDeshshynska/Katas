/*
Moving Zeros To The End
Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.
*/
using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
        {
            List<int> list = new List<int>();
            int count = 0;
            foreach (var i in arr)
            {
                if (i == 0) count++;
                else list.Add(i);
            }
            for(int j = 0; j<count;j++)
            {
                list.Add(0);
            }
                return list.ToArray();
        }
}