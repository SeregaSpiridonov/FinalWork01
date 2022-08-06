/*
Написать программу которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
[hello, 2 , world, :-)][2, :-)]
*/
string[] EnterArray()
{
    Console.Write("Введите колличество строк: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[n];
    for (int j = 0; j < array.Length; j++)
    {
        Console.WriteLine($"Введите строку {j+1}: ");
        array[j] = Console.ReadLine()!;
    }
    Console.WriteLine();
    return array;
}
void LineWeight(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length < 4 && arr[i].Length > 0) count++;
    }
    string[] arr2 = new string[count];
    count = 0;
    for (int j = 0; j < arr.Length; j++)
    {
        if(arr[j].Length < 4 && arr[j].Length > 0)
        {
            arr2[count] = arr[j];
            count++;
        }
    }
    Console.WriteLine("Строки меньше 4х знаков: [" + string.Join(", ", arr2) + "]");
}
LineWeight(EnterArray());