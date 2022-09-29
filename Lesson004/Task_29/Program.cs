// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.



int[] GetArray (int size)   
{
    int[] array = new int[size]; 
    for (int i = 0; i < array.Length; i++)  
    {
        array[i] = new Random().Next(100);   
    }
    return array;
}

int[] resultArray = GetArray(8);

Console.WriteLine($"Result array: [ {String.Join(", ", resultArray)} ]");
