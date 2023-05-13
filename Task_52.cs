//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m = 4;
int n = 5;

int[,] arr = FillArray(m, n);

int[,] FillArray(int m, int n)
{
    Random rnd = new Random();
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    return array;
}

double summ = 0;

for (int i = 0; i < arr.GetLength(1); i++)
{
    for (int j = 0; j < arr.GetLength(0); j++)
    {
        summ += arr[j, i];
    }
    Console.WriteLine(summ/arr.GetLength(0));
    summ = 0;
}



int inputNumber(string message)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(message);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}
