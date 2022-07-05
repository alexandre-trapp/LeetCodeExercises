// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var result = TwoSum(new int[3] {3,2,3}, 6);

foreach (var num in result)
    Console.WriteLine(num + ",");

int[] TwoSum(int[] nums, int target)
{

    var result = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        for (int n = 0; n < nums.Length; n++)
        {
            if (i == n)
                continue;

            int sum = nums[i] + nums[n];
            if (sum == target)
            {
                result.Add(i);
                result.Add(n);

                return result.ToArray();
            }
        }
    }

    return result.ToArray();
}