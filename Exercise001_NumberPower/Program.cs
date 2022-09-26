static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
}

int NumberInput(string message) //позволяет ввести именно число с консоли, воз-вращая 
 {                               //пользователя к вводу, если число не распознано, до 
    int index = 0;               //тех пор пока ввод не будет удачен
    int number = 0;
    while (index < 1)
    {
        Console.Write(message);
        string text = Console.ReadLine();
            if (int.TryParse(text, out number))
                { Console.WriteLine($"Вы ввели число: {number} . "); index++; }
            else
                { Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); }
    }
    return number;
 }

int PowerNumber(int number, int degree)
 {
    int res = number;
    for(int j = 1; j < degree; j++)
        { res *= number; }  
    return res;
 }
 
string text = new String('*', 40);  // Выводит заданное количество символов, в дан-ном случае 40
emptyString(6);
Console.WriteLine(text);
Console.WriteLine("   \t Задача 2");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("   Напишите цикл, который принимает на вход \r\nдва числа (A и B) и возводит число A в \r\nнатуральную степень B.");
emptyString(1);
int basis = NumberInput("Введите число A: ");
int deg = NumberInput("Введите число B: ");
Console.WriteLine($"{basis} в степени {deg} = {PowerNumber(basis, deg)}");
Console.WriteLine(text);
emptyString(2);
