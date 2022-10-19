/*Задача 1: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] NewArray(int len) //функция для вывода массива случайных 3хзн чисел
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,999); 
    }
    return array;
}

void PrintArray(int[] array) //функция вывода на экран 
{
	for (int i = 0; i < array.Length; i++)
	{
		System.Console.Write($"{array[i]}\t");
	}
	System.Console.WriteLine();
}

int[] array = NewArray(5); 
PrintArray(array);

int CountEvenNumber(int number)// для нахождения количесва четных чисел в массиве
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			array[i] = 1; //если число четное то присваеваем ему 1 для дальнейшего подсчета количества.
            sum = sum + array[i];
		}
	}
	return sum;
}

int sum = 0;
int even = CountEvenNumber(sum);
Console.Write($"количество четных чисел в массиве равно {even}");

