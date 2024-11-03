using Tyuiu.GridinAE.Sprint3.Task4.V29.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах             *");
Console.WriteLine("* Задание #4                                                           *");
Console.WriteLine("* Вариант #29                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение  *");
Console.WriteLine("* функции y=cos(x)/x                                                   *");
Console.WriteLine("* При х = 0 пропустить значение. Полученные значения суммировать.      *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(-5, 5));