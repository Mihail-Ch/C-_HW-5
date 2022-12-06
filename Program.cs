//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.  [345, 897, 568, 234] -> 2


void RandomArray(int from, int to, int[] arr) {
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        arr[index] = new Random().Next(from,to);
        index++; 
    }
}

void Print(int[] randomArray) {
    int count = randomArray.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.WriteLine(randomArray[pos]);
        pos++;
    }
}

int[] array = new int[4];
RandomArray(
    100, 999, array
);
Print(
    array
);

int ChetnNumber(int[] array) {
    int countPlus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) {
            countPlus += 1;
        } 
    }
    Console.WriteLine($"Количество четных чисел в массиве = {countPlus}");
    return countPlus;
}

ChetnNumber(
    array
);


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


int[] nextArray = new int[5];
RandomArray(
    -99, 99, nextArray
);
Print(
    nextArray
);

int SumOnNotChetnPlace(int[] arrayNext) {
    int count = arrayNext[1];
    for (int i = 3; i < arrayNext.Length; i += 2)
    {
        count += arrayNext[i];
    }
    Console.WriteLine($"Сумма элементов стоящих на нечетных позициях = {count}");
    return count;
}
SumOnNotChetnPlace(
    nextArray
);


/*
 Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.
 [3 7 22 2 78] -> 76
 */

int[] arrayRealNumber = new int[5];
RandomArray(
    0, 99, arrayRealNumber
);
Print(
    arrayRealNumber
);

int DifferentMaxOnMin(int[] arrRealNum) {
    int result = 0;
    int maxNum = arrRealNum.Max();
    int minNum = arrRealNum.Min();
    result = maxNum - minNum;
    Console.WriteLine($"Разницу между максимальным и минимальным элементом массива = {result}");
    return result;
}

DifferentMaxOnMin(
    arrayRealNumber
);