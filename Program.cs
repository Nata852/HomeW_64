int GetNumber(string message)
{
    int resalt = 0;
    while(true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out resalt))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return resalt;
}
void WriteNubers(int number)
{
    if(number ==1) Console.Write("1 ");
    else
    {
        Console.Write($"{number} ");
        WriteNubers(number - 1);
    }
}
int num = GetNumber("Введите натуральное число: ");
WriteNubers(num);
   
