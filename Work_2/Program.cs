
///Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Prompt(string length) 
{
    System.Console.Write (length);

    return int.Parse(Console.ReadLine());
}
void PrintArray(int [,] array) // вывод массива
{   
    Console.WriteLine(); 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                System.Console.Write($"{array[i, j]}\t");
            }
        }
        Console.WriteLine(); 
    }
}
void FillArray(int [,] matr)//заполнение массива
{  
    Random random = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]=random.Next(0, 10);
        }
    }
}
void MinSum(int [,] matrix) //нахождение строки с минимальной суммой 
{
    int min = 0;
    for (int i =1 ; i< matrix.GetLength(0); i++)
    {
        int sum_i=0;
        int sum_min=0;
        for (int j =0 ; j< matrix.GetLength(1); j++)
        {
            sum_i = sum_i + matrix[i,j];
            sum_min = sum_min + matrix[min,j];
        }
        if (sum_i < sum_min)
        {
            min = i;
        }
    }  
 Console.Write($"Строка с наименьшей суммой элементов: {min+1}");
}
int n = Prompt("Введите размер квадратного массива:  ");
int [,] matrix = new int [n,n];
FillArray(matrix);
PrintArray(matrix);
MinSum(matrix);
