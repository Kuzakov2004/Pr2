using System; 
using System.Collections.Generic; 
 
class Program 
{ 
    static void Main() 
    { 
        int[] nums = { 1, 2, 3, 4, 5};
        bool flag = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    if (i != j)
                    {
                        flag = true;
                        break;
                    }
                }
            } 
        }
        Console.WriteLine(flag);
    } 
}