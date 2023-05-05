int[,] array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
int rows = array.GetLength(0);
int cols = array.GetLength(1);


for (int j = 0; j < cols; j++)
{
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    double avg = (double)sum / rows;
    Console.WriteLine("Среднее арифметическое элементов в столбце {0} равно {1}.", j, avg);
}
