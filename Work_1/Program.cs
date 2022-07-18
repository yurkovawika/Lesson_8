///Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void SelectionSort(int [,] matrix) //сортировка массива
{
    System.Console.Write("Упорядоченный массив:");
    for (int i =0 ; i< matrix.GetLength(0); i++)
    {
        for (int j =0 ; j< matrix.GetLength(1)-1; j++)
        {
            for(int k = 1; k < matrix.GetLength(1);k++)
            {
                if (matrix[i,k]<matrix[i,k-1])
                {
                    int temp = matrix[i,k-1];
                    matrix[i,k-1]=matrix[i,k];
                    matrix[i,k] = temp;
                }
            }
        }
    }
   
}

int n = Prompt("Введите кол-во строк в массиве: ");
int m = Prompt("Введите кол-во столбцов в массиве: ");
int [,] matrix = new int [n,m];
FillArray(matrix);
PrintArray(matrix);
SelectionSort(matrix);
PrintArray(matrix);