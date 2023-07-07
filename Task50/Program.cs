/* 
Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();

Console.WriteLine($"Input row to find your number: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Input col to find your number: ");
int userCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,] CreateArray(int row, int col, int min, int max){ 
    Random rand = new Random(); 
    int [,] array = new int [row, col]; 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            array[i,j] = rand.Next(min,max+1); 
        } 
    } 
    return array; 
} 
 
void PrintArray(int [,] array){ 
    int row = array.GetLength(0); 
    int col = array.GetLength(1); 
    for (int i = 0; i < row; i++) 
    { 
        for (int j = 0; j < col; j++) 
        { 
            Console.Write($"{array [i,j]}\t"); 
        } 
        Console.WriteLine(); 
    } 
}

Console.WriteLine("Here is our random array: ");

int [,] array = CreateArray(3, 4, 0, 10); 
PrintArray(array); 
Console.WriteLine(); 
if (userRow > array.GetLength(0) || userCol > array.GetLength(1)){
        Console.WriteLine($"There is no number for your coordinates {userRow}, {userCol}.");
}
else{
        object value = array.GetValue(userRow, userCol);
        Console.WriteLine($"{value} is the number for your coordinates {userRow}, {userCol}.");
}
