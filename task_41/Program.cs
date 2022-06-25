/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

using static System.Console;
Clear();
Write("Введите элементы массива через пробел: ");
int [] array=GetArrayFromString(ReadLine());
WriteLine($"[{String.Join(", ", array)}]");
WriteLine($"Число положительных элементов массива равно: {SumPositivArray(array)}");


int [] GetArrayFromString(string arrayStr)
{
    string [] arS=arrayStr.Split(new char[]{' ', ',', '*'}, StringSplitOptions.RemoveEmptyEntries);
    int [] result=new int[arS.Length];
    for(int i=0; i<arS.Length; i++)
    {
        result[i]=int.Parse(arS[i]);
    }
    return result;
}


int SumPositivArray(int [] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
       int a=array[i]>0 ? count+=1 : count+=0;
    }
    return count;
}