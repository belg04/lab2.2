// Лукьянов Глеб     22-исп-2\1      Уровень:Высокий   Номер:2
Console.Write("Введите двухзначное число:");
int numder = int.Parse(Console.ReadLine());
Console.Write("Введите число n чтобы определть входит ли это число :");
int n = int.Parse(Console.ReadLine());

    if ((numder % 10 == 5) || (numder / 10 == 5))
    {
        Console.WriteLine("В числе есть 5");
    }

    else
    {
        Console.WriteLine("В числе нет 5");
    }


    if ((numder % 10 == n) || (numder / 10 == n))
    {
        Console.WriteLine("В числе есть n");
    }

    else
    {
        Console.WriteLine("В числе нет n");
    }





