static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
 { 
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
 }

void ArrayInput(int[] collect) //Заполнение массива целыми числами с консоли
 {
    int index = 0;
    int length = collect.Length;
    while (index < length)
    {
        Console.Write("Введите число:  ");
        string text = Console.ReadLine();
            if (int.TryParse(text, out collect[index]))
                { Console.WriteLine($"Вы ввели {index + 1} элемент. ", collect[index]); index++; }
            else
                { Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); }
    }
 }

void PrintArray(int[] array) // вывод массива на консоль
 {
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
 }

int MaxElement(int[] arr, int n) // возвращает n-ый максимальный элемент принимаемого массива
 {
    for(int i = 0; i < n; i++)
    {   
        int max = i;
        for(int j = i + 1; j < arr.Length; j++)
        {
            if(arr[j] > arr[max]) max = j;    
        }    
        int temp = arr[i]; arr[i] = arr[max]; arr[max] = temp;  
    }
    return arr[n-1];
 }

string text = new String('*', 40);  // Выводит заданное количество символов, в дан-ном случае 40
int[] array = new int[8]; 
emptyString(3);
Console.WriteLine(text);
Console.WriteLine("   \t Задача 3");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("   Напишите программу, которая задаёт мас- \r\nсив из 8 элементов, выводит их на экран, и\r\nищет второй максимум (элемент меньше макси-\r\nмального, но больше всех остальных)");
emptyString(1);
ArrayInput(array);
emptyString(1);
PrintArray(array);
emptyString(1);
int max2 = MaxElement(array,2);
Console.WriteLine($"\n max2 = {max2}");
Console.WriteLine(text);
emptyString(2);
