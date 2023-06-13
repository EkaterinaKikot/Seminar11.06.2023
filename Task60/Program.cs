void InputMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           for(int m = 0; m < matrix.GetLength(2); m++) 
           matrix[i, j, m] = new Random().Next(-30, 31);
        }
        
    }
}

void PrintMatrix(int[,,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int m = 0; m < matrix.GetLength(2); m++)
            Console.Write($"{matrix[i, j, m], 1}({i},{j},{m}) \t");
            Console.WriteLine();
        }
        
    }
}

static int RandomValue(int[,,] matrix, int i, int j, int m)
{
    int value = default;
    bool flag = true;
    while (flag)
    {
        bool noStop = true;
        value = new Random().Next(10, 100);
        for (int x = 0; x < matrix.GetLength(0) && noStop; x++)
        {
            for (int y = 0; y < matrix.GetLength(1) && noStop; y++)
            {
                for (int z = 0; z < matrix.GetLength(2) && noStop; z++)
                {
                    if (matrix[x, y, z] == value) 
                        noStop = false; 
                    if (x == i && y == j && z == m) 
                        flag = false; 
                }
            }
        }
    }
    return value;
}

Console.Clear();
Console.WriteLine("Массив размером 2 x 2 x 2: ");
int[,,] matrix = new int[2, 2, 2];
InputMatrix(matrix);
PrintMatrix(matrix);


