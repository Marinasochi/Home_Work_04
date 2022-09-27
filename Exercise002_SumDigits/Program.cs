static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
}

int SumDigits(int numb) // возвращает сумму цифр принимаемого целого числа
{
    if(numb < 0)
    {   numb *= -1; }
    int sum = numb%10; numb /= 10;
    while(numb > 0)
    {
        sum = sum + numb%10;
        numb /= 10;
    }
    return sum;
}

void OnlyTheNumber(string message) // вычисляет сумму цифр целого числа с помощью вызываемого метода метода 
{                                  // позволяет ввести целое число, обрабатывая исключения и 
    try                            // возвращая пользователя к вводу, пока он не будет удачен
    {
        Console.WriteLine(message);
        string value = Console.ReadLine();
        int number = int.Parse(value);
        int summa = SumDigits(number);
        Console.WriteLine($"Сумма цифр данного числа = {summa}");
    }

    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Это не число!"); Console.ResetColor();
        OnlyTheNumber(message);
    }
}

string text = new String('*', 40);  // Выводит заданное количество символов, в данном случае 40
emptyString(6);
Console.WriteLine(text);
Console.WriteLine("    Задача 2");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Напишите программу, которая принимает \r\nна вход число и выдаёт сумму цифр в числе.");
emptyString(1);
OnlyTheNumber("Введите число");
Console.WriteLine(text);
emptyString(2);
