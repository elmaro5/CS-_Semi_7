int m = 9;
int n = 8;

double[,] arr = FillArray(m,n);

double[,] FillArray(int m, int n)
{   
    Random rnd = new Random();
    double[,] array = new double[m, n];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 99) + Math.Round(rnd.NextDouble(), 1);
            Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return array;
}

