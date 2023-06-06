//задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//каждой строки двумерного массива



/*int [,] Create2DRandomArray (int rows, int cols)
{
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            {
                array[i,j] = new Random().Next(1, 10);
            }
    }
    return array;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

void  DecreaseNumRows (int [,] array)
{
    for ( int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    
}

Console.WriteLine("Input count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());


int [,] result = Create2DRandomArray(user_rows, user_columns);
Show2dArray(result);
DecreaseNumRows(result);
Console.WriteLine();
Show2dArray(result);
*/


//задача 56
//Задайте прямоугольный двумерный массив, напишите программу, которая будет находить строку с
//наименьшей суммой элементов. Программа считает сумму элементов каждой строки и выводит номер строки
// с наименьшей суммой элементов

/*int [,] Create2DRandomArray (int rows, int cols)
{
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
            {
                array[i,j] = new Random().Next(1, 10);
            }
    }
    return array;
}

void Show2dArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

int SumNumRow (int [,] array)
{
    int minRow = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0,i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}


Console.WriteLine("Input count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns: ");
int user_columns = Convert.ToInt32(Console.ReadLine());

int [,] firstArray = Create2DRandomArray(user_rows, user_columns);
Show2dArray(firstArray);

Console.WriteLine($"Minimal sum  in {SumNumRow(firstArray)} row");
*/


//Задача 58
//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц


/*Console.WriteLine("Input count of rows first array: ");
int user_rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns first array: ");
int user_columnsA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input count of rows second array: ");
int user_rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input count of columns second array: ");
int user_columnsB = Convert.ToInt32(Console.ReadLine());

int [,] CreateArray(int rows, int columns, int min, int max)
{
    int [,] array = new int [rows,columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] MultiplicationMatrix (int [,] arrayA, int [,] arrayB)
{
    int [,] arrayC = new int [arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(0); k++)
            {
                arrayC[i,j] += arrayA[i,k] * arrayB[k,j];
            }
        }
    }
    return arrayC;
}
if (user_columnsA != user_rowsB)
{
    Console.WriteLine("Impossible size!");
    return;
}

int [,] matrixA = CreateArray( user_rowsA, user_columnsA, 0, 10);
ShowArray(matrixA);
Console.WriteLine();

int [,] matrixB = CreateArray(user_rowsB, user_columnsB, 0, 10);
ShowArray(matrixB);
Console.WriteLine();

int [,] result = MultiplicationMatrix(matrixA, matrixB);
ShowArray(MultiplicationMatrix(matrixA, matrixB));
*/

// Задача 60
//Сформируйте трехмерный массив из неповторяющихся трехзначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента

/*void Array3D (int [,,] array)
{
    int [] temp = new int [array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int num;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(10, 100);
        num = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    num = temp[i];
                }
                num = temp[i];
            }
        }
    }
    int count = 0;
    for ( int x = 0; x < array.GetLength(0);  x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}
void Show3dArray (int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i}, {j}, {k})");
            }
            Console.WriteLine();
        }
    }
}



Console.WriteLine(" Input your massive X number: ");
int numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input your massive Y number: ");
int numY = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input your massive Z number: ");
int numZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input your min value: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input max value: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [,,] array3D = new int [numX, numY, numZ];
Array3D(array3D);
Show3dArray(array3D);
*/

//Pадача 62
// Напишите программу, которая заполнит спирально массив 4 на 4.

int size = 4;
int [,] snakesMatrix = new int [size, size];
int temp = 1;
int i = 0;
int j = 0;

while(temp <= snakesMatrix.GetLength(0) * snakesMatrix.GetLength(1))
{
    snakesMatrix[i,j] = temp;
    temp++;
    if (i <= j + 1 && i + j < snakesMatrix.GetLength(1) - 1)
    j++;
    else if (i < j && i + j >= snakesMatrix.GetLength(0) - 1)
    i++;
    else if (i >= j && i + j > snakesMatrix.GetLength(1) - 1)
    j--;
    else
    i--;
}

PrintArray(snakesMatrix);

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] / 10 <= 0)
            Console.WriteLine(array[i,j] + " ");
            else
            Console.WriteLine(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}








