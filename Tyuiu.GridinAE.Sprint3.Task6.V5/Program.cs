using Tyuiu.GridinAE.Sprint3.Task6.V5.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Обработка целочисленной информации                             *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #5                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                  *");
Console.WriteLine("* принадлежащих числовому отрезку [15, 22] сумму всех делителей        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().GetSumTheDivisors(15, 22));
Console.ReadLine();