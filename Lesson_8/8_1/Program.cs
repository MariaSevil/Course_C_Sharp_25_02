﻿// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для
// пользователя.



void Print(int[,] arr)
{

    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}
void FirstWithLast(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
if( row != column)
{
    Console.WriteLine(" ");
return;
}
    for (int i = 0; i < row; i++)
    for(int j = 0; j < i ; j++)
        (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
}
Console.WriteLine(" Enter the number of rows: ");
int num_row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the number of columns:");
int num_column = int.Parse(Console.ReadLine()!);

int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);
int[,] mass = MassNums(num_row, num_column, start, stop);
Print(mass);
FirstWithLast(mass);
Print(mass);
