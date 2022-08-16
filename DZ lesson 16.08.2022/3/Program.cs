// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] MyArray = new int[8];

Random array = new Random();
for (int i = 0; i < MyArray.Length; i++)
    MyArray[i] = array.Next(-1000, 1000);
var str = string.Join(" ", MyArray);

Console.WriteLine("[{0}]", string.Join(", ", MyArray));