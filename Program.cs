//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
void FillArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-100, 100);
            Array[i, j] = Array[i, j] / 5;
        }
}
void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($" {Array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}   
Console.Clear();
Console.Write("Введите число строк массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
Double[,] Array1= new Double[m,n];
FillArray(Array1);
PrintArray(Array1);
