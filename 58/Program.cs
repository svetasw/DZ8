int rows = ReadInt("Enter number of the columns rows: ");
            int columns = ReadInt("Enter number of the columns: ");
            int[,] array = new int[rows, columns];
            int[,] secondArray = new int[rows, columns];
            int[,] resultArray = new int[rows, columns];
            
            FillArrayRandom(array);
            PrintArray2D(array);
            
            Console.WriteLine();
            
            FillArrayRandom(secondArray);
            PrintArray2D(secondArray);
            
            Console.WriteLine();
            
            if (array.GetLength(0) != secondArray.GetLength(1))
            {
                Console.WriteLine(" Can't multiplied ");
                return;
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    resultArray[i, j] = 0;
                    for (int k = 0; k < array.GetLength(1); k++)
                    {
                       resultArray[i, j] += array[i, k] * secondArray[k, j];
                    }
                }
            }
            
            PrintArray2D(resultArray);
            
            
            
            // Input function
            int ReadInt(string message)
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            
            // Function of filling the array with random numbers from 1 to 9
            void FillArrayRandom(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(1, 10);
                    }
                }
            }
            
            // Function of outputting a two-dimensional array to the terminal 
            void PrintArray2D(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }            
