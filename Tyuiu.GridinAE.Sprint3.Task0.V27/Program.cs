using Tyuiu.GridinAE.Sprint3.Task0.V27.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Оператор цикла for                                             *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #27                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда  *");
Console.WriteLine("* по данной формуле                                                    *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: n = 5                                               *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().GetSumSeries(5, 1, 13));
Console.ReadKey();