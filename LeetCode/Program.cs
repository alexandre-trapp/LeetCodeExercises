// See https://aka.ms/new-console-template for more information
using LeetCode;

// Verify animals
var animalsLength = OtherExercises.Animals("Elephant-Tiger-Lion-");
Console.WriteLine("with length " + animalsLength);
Console.WriteLine();

// Anagram
bool isAnagram = OtherExercises.IsAnagram("car", "rat");
Console.WriteLine("is anagram " + isAnagram);
Console.WriteLine();

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