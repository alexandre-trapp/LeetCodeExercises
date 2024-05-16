using LeetCode;
using System.Text;

#region EncodeDecode strings

var input = new List<string>
{
    "lint","code","love","/","you"
};

var resultEncode = EncodeDecodeString.Encode(input);
Console.WriteLine(resultEncode);

var resultDecode = EncodeDecodeString.Decode(resultEncode);
Console.WriteLine("[" + string.Join(",", resultDecode) + "]");

return;

#endregion

#region TopKFrequentElements
var elements = new int[] { 1, 1, 2, 3, 3, 4, 5, 4, 6, 4};
var k = 2;

var top = TopKFrequentElements.TopKFrequent(elements, k);
Console.WriteLine(string.Join(',', top));

#endregion

#region GroupAnagrams

// GroupAnagrams();

#endregion

#region ValidAnagrams

//bool isAnagram = ValidaAnagram.IsAnagram("tar", "rat");
//Console.WriteLine("is anagram " + isAnagram);
//Console.WriteLine();

#endregion

return;


// Two arrays sum
var result = TwoSumArray.TwoSumBruteForce(
    nums: new int[3] { 3, 2, 3 },
    target: 6);

var result1 = TwoSumArray.TwoSumHashMap1(
    nums: new int[4] { 1, 2, 3, 4 },
    target: 7);

var result2 = TwoSumArray.TwoSumHashMap2(
    nums: new int[6] { 3, 2, 1, 8, 6, 9 },
    target: 15);

var result3 = TwoSumArray.TwoSumHashMap3(
    nums: new int[5] { 8, 6, 8, 1, 3 },
    target: 9);

var result4 = TwoSumArray.TwoSumHashMap4(
    nums: new int[4] { 8, 9, 7, 6 },
    target: 14);

var result5 = TwoSumArray.TwoSumHashMap5(
    nums: new int[5] { 9, 5, 8, 2, 4 },
    target: 10);

Console.WriteLine("TwoSumBruteForce: " + string.Join(',', result));
Console.WriteLine("TwoSumHashMap1: " + string.Join(',', result1));
Console.WriteLine("TwoSumHashMap2: " + string.Join(',', result2));
Console.WriteLine("TwoSumHashMap3: " + string.Join(',', result3));
Console.WriteLine("TwoSumHashMap4: " + string.Join(',', result4));
Console.WriteLine("TwoSumHashMap5: " + string.Join(',', result5));

void TestTreasuryChestCases()
{
    int[][] testCases = new int[][] {
        new int[] { 1, 4, 2 },
        new int[] { 7, 8, 9 },
        new int[] { 3, 5, 2, 6 },
        new int[] { 2, 3, 1, 5, 4 },
        new int[] { 9, 7, 6, 3 },
        new int[] { 10, 5, 8, 2, 4 },
        new int[] { 6, 4, 7, 3, 5 },
        new int[] { 1, 2, 3, 4, 5 },
        new int[] { 8, 9, 10, 7 },
        new int[] { 2, 2, 2, 2, 2 }
    };

    int[] timeLimits = { 3, 2, 4, 5, 3, 6, 5, 6, 4, 5 };
    int[] results = new int[10];

    int[] expectedResults = { 5, 8, 8, 9, 16, 13, 16, 15, 18, 6 };

    Console.Write("run algorithm...");

    for (int i = 0; i < testCases.Length; i++)
    {
        Console.WriteLine("-------");

        int[] chests = testCases[i];
        int t = timeLimits[i];

        int result = ChestTreasury.GetResult(chests, t);
        results[i] = result;
        Console.WriteLine($"Test Case {i + 1}: Chests = [{string.Join(", ", chests)}], Time Limit = {t}, Result = {result}");

        bool equals = Assert.AreEqual(expectedResults[i], results[i]);
        Console.WriteLine(equals ? "test passed" : "test failed!");
        Console.WriteLine("-------");
    }
}

static void GroupAnagrams()
{
    var groupAnagrams = GroupAnagram.GroupAnagrams(new string[] {
            "eat","tea","tan","ate","nat","bat"
        });

    var sb = new StringBuilder("[");
    foreach (var anag in groupAnagrams)
    {

        sb.Append("[" + string.Join(",", anag) + "],");
    }
    sb.Append("]");

    Console.WriteLine(sb.ToString());
    Console.ReadLine();
}

public static class Assert
{
    public static bool AreEqual(int expected, int actual)
    {
        Console.WriteLine($"expected={expected}; actual={actual}");
        return expected == actual;
    }
}