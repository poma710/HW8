class Program
{
    static void Main(string[] args)
    {
        
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        
        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int col = int.Parse(Console.ReadLine());

        
        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
        {
            
            Console.WriteLine("Значение элемента: " + matrix[row, col]);
        }
        else
        {
            
            Console.WriteLine("Элемент с такими координатами не существует в массиве.");
        }

        Console.ReadLine();
    }
}
