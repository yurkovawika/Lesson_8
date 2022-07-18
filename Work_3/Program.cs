// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void SumMatrix(int [,] matrix1, int [,] matrix2)//сумма матриц
{
    for (int i =0 ; i< matrix1.GetLength(0); i++)
    {
        for (int j =0 ; j< matrix1.GetLength(1); j++)
        {
            matrix1[i,j]=matrix1[i,j]*matrix2[i,j];
        }
    }
    Console.WriteLine("Произведение матриц:"); 
    PrintArray(matrix1);
}

int n = Prompt("Введите размер массивов:  ");
int [,] matrix1 = new int [n,n];
int [,] matrix2 = new int [n,n];
FillArray(matrix1);FillArray(matrix2);
PrintArray(matrix1);PrintArray(matrix2);
SumMatrix(matrix1,matrix2);