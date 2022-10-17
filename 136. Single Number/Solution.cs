﻿namespace _136._Single_Number;

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int res = 0;
        foreach (int num in nums)
            res ^= num;
        return res;
    }
}
