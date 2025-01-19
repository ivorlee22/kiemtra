class Program
{
    public static void Main()
    {
        //    int[] nums = new int[5];
        //    nums[0] = 1;
        //    nums[1] = 2;
        //    nums[2] = 3;
        //    nums[3] = 4;
        //    nums[4] = 0;

        //    Console.WriteLine(MissNum(nums));

    }

    public static int MissNum(int[] nums)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int tmp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = tmp;
                }
            }
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if ((nums[i + 1] - nums[i]) != 1)
            {
                return nums[i] + 1;
            }
        }

        return (nums[nums.Length - 1] + 1);

    }
}