using Tyuiu.GridinAE.Sprint3.Task2.V10.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Оператор цикла do-while                                        *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #10                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет      *");
Console.WriteLine("* произведение ряда по формуле                                         *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: t = 1                                               *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().GetMultiplySeries(1, 1, 13));
Console.ReadKey();