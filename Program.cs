// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
		
string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan",};

PrintArray(array1);
PrintArray(array2);
PrintArray(array3);

string[] ArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
          newArray[j] = array[i];
           j++;
        }
    return newArray;
}

void ShowArray(string[] array)
{
  if(array.Length == 0)
      Console.WriteLine($"К сожалению отсутствуют!");
  else
    foreach (var item in array)
        Console.Write($"["+ item + "] ");
    Console.WriteLine();  
}

void PrintArray(string[] array)
{
  string[] shortArray = ArrayLength(array);
  Console.Write("Введенные массивы: ");
  ShowArray(array);
  Console.Write($"Массивы равные или меньше 3x символов: ");
  ShowArray(shortArray);
  Console.WriteLine();
}



