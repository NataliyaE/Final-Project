/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма
*/

Console.WriteLine("Input the Count of Array Elements");
int CountElements = Convert.ToInt32(Console.ReadLine());
string[] FirstArray = new string [CountElements];
string[] SecondArray = new string [CountElements];

FillFirstArray(FirstArray);
PrintFirstArray(FirstArray);
Console.WriteLine();
Console.WriteLine();
PrintSecondArray(FirstArray);

void FillFirstArray(string[] FirstArray)
{
    for (int i = 0; i < CountElements; i++)
    {
        Console.WriteLine("Input the Element");
        FirstArray[i] = Console.ReadLine();
    }
}

void PrintFirstArray(string[] FirstArray)
{
    int i = 0;
    while (i < CountElements)
    {
        Console.Write($"{FirstArray[i]}; ");
        i ++;
    }
}

void PrintSecondArray(string[] FirstArray)
{
    int j = 0;
    for (int i=0; i < CountElements; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            SecondArray[j] = FirstArray[i];
            Console.Write($"{SecondArray[j]}; ");
            j++;
        }
    }
}
