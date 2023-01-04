//Написать программу, которая из имеющегося массива строк формирует новый массив из строr,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string [] CreatedNewArray()
{
    string[] array = new string[5];
    array[0] = "Hello";
    array[1] = "2";
    array[2] = "world";
    array[3] = ":-";
    array[4] = "Russia";
 return array;
}

void ShowNewArray(string[] array)
{
   for(int i = 0;i < array.Length;i++)
   {
    Console.Write(array[i] + " ");
   }
}

void Simvol(string[] array)
{
    string[] a = new string[5];
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i].Length <= 3)
        {
            Console.Write(array[i] + " ");
        }
    }
}

ShowNewArray(CreatedNewArray());
Console.WriteLine();
Simvol(CreatedNewArray());
