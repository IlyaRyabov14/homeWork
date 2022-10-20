int UserSum(int size)
{
   int number;
   int Result = 0; 
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число ");
        int.TryParse(Console.ReadLine(), out number);
        if(number > 0)
        {
            Result = Result + number; 
        }
    }
    return Result;
}

int FinishResult = UserSum(6);
Console.WriteLine($"Cумма чисел больше нуля равна {FinishResult}");