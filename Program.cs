//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Random rnd = new Random();
int[] nums = new int[4]; ;
int count = 0;

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next(100, 999);
    Console.Write(nums[i] + " ");
    if (nums[i] % 2 == 0) count++;
}

Console.WriteLine($"-> {count}");
