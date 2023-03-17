
//задание 1

int[,] Create2DArray(int columns, int rows)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(1,10);
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Newarr(int[,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) -1 ; j++)
        {
            for (int k = 0; k < array.GetLength(1) -1 ; k++)

                if(array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    
                    array[i,k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
           
            
       }
       return array;
}

  




// задание 2

int[,] Create2DArray(int columns, int rows)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(1,10);;
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumStringarray(int[,] array)
{
    int index = 0, minsum = 0;
    
   for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
      
        {
            sum += array[i, j];
        }
         if ( i == 0)
        {
            minsum = sum;
        }
        else 
        {
           if (sum < minsum)
           {
            minsum = sum;
            index = i;
           }
        
        }      
}
    Console.WriteLine($"Строка с минимальной суммой элементов {index + 1}");
}


  
Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = Create2DArray(columns, rows);
int[,] MyArray = Create2DArray(columns, rows);
Show2DArray(MyArray);
Console.WriteLine();
SumStringarray(array);