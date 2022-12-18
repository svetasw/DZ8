Console.WriteLine("Enter the number of line");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Array before change");
            PrintArray(numbers);
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                    {
                        if (numbers[i, z] < numbers[i, z + 1]) 
                        {
                            int temp = 0;
                            temp = numbers[i, z];
                            numbers[i, z] = numbers[i, z + 1];
                            numbers[i, z + 1] = temp;
                        }
                   }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array with ordered values");
            PrintArray(numbers);
            
            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }