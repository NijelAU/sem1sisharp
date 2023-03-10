// Задача 48: Задайте двумерный массив размера m на n, каждый
//элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

System.Console.Write("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] FillDoubleArray(int m, int n)
{
    int [,] newDoubleArray = new int [m, n];
    for (int i = 0; i <newDoubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < newDoubleArray.GetLength(1); j++)
        {
            newDoubleArray [i,j] = i +j;
        }
    }
    return  newDoubleArray;
}


void ShowDoubleArray (int [,] arrayIn)
{
    for (int i = 0; i <arrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++)
        {
            Console.Write($" {arrayIn [i,j]} ;");
        }
        Console.WriteLine();
    }
}

int [,] userArray = FillDoubleArray (m,n);
ShowDoubleArray (userArray);