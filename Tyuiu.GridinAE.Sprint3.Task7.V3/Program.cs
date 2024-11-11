using Tyuiu.GridinAE.Sprint3.Task7.V3.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #3                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, производящую табулирование функции f(x)          *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

DataService ds = new();
double[] values = ds.GetMassFunction(-5, 5);

Console.WriteLine(" X | F(X)");
int i = 0;
foreach (double value in values)
{
    if (i - 5 < 0)
        Console.WriteLine($"{i - 5} | {value}");
    else
        Console.WriteLine($" {i - 5} | {value}");
    i++;
}

Console.ReadKey();