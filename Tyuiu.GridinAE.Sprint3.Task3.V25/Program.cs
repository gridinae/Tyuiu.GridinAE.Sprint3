using Tyuiu.GridinAE.Sprint3.Task3.V25.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Оператор цикла foreach                                         *");
Console.WriteLine("* Задание #3                                                           *");
Console.WriteLine("* Вариант #25                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв u      *");
Console.WriteLine("* находящихся на соседних позициях в строке:                           *");
Console.WriteLine("* kjhgfuu gujut dtuu                                                   *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().GetMinCharCount("kjhgfuu gujut dtuu", 'u'));