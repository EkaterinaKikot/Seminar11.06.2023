void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = new Random().Next(-30, 31);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

void  MultiplicationMatrix(int[,] result, int[,] matrix1, int[,] matrix2)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");

int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
while (size[0] != size[1])
{
    Console.Write("Вы ошиблись!\nВведите размер матрицы: ");
    size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix1 = new int[size[0], size[1]];
int[,] matrix2 = new int[size[0], size[1]];
int[,] result = new int[size[0], size[1]];
Console.WriteLine("Первая матрица: ");
InputMatrix(matrix1);
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица: ");
InputMatrix(matrix2);
PrintMatrix(matrix2);
Console.WriteLine("Результирующая матрица: ");
MultiplicationMatrix(result, matrix1, matrix2);
PrintMatrix(result);

