using System;

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentMinimum = int.MaxValue;
int total = 0;

foreach (int i in array)
{
    if (i < currentMinimum)
    {
        currentMinimum = array[i];
    }
}

Console.WriteLine(currentMinimum);

foreach (int i in array)
{
    total += i;
}

float average = (float)total / array.Length;
Console.WriteLine(average);