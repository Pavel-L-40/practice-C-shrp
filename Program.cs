// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("\"");
        System.Console.Write(array[i]);
        System.Console.Write("\"");
        if (i != array.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
}

int sizeNewArr(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArr(string[] array, int size){
    string []newArr = new string[size];
    int j = 0;
    if(size == 0){
        return newArr;
    }
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[j] = array[i];
            j++;
        }
    }
    return newArr;
}

string[] arrayOne = { "hello", "2", "world", "!-&" };

PrintArray(arrayOne);
System.Console.Write(" -> ");
int sizeNewArray = sizeNewArr(arrayOne);
string[] desiredArray = NewArr(arrayOne, sizeNewArray);
PrintArray(desiredArray);