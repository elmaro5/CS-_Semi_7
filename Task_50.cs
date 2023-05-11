int m = 6;
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

int elr = inputNumber(("Введите ряд, начиная с 0: "));
int els = inputNumber(("Введите столбец, начиная с 0: "));

if (arr.GetLength(0) > elr && arr.GetLength(1) > els)
{
    Console.WriteLine("Элемент существует!");
}
else
{
    Console.WriteLine("Элемент отсутствует!");
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
            if (number >= 0)
                break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
    return number;
}