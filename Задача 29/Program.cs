// Задача 29:Напишите программу, которая будет создавать массив 
// из 8 символов и заполнять значениями от пользователя
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
void PrintArray(int[]array)
{
    System.Console.WriteLine($"[{String.Join(",", array)}]");
}

System.Console.Clear();
int[] array = new int [8];
int index = 0;

while (true)
{
    System.Console.WriteLine ("Press Enter for quit or enter number: ");
    string a = Console.ReadLine();

    if (a == string.Empty)
    {
        break;
    }
    array[index] = ConvertToInt32(a);
    index ++;
    PrintArray(array);
    if (index== array.Length)
    {
        index = 0;
    }
}
System.Console.WriteLine("Finish");