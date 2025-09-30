using Tyuiu.PupovAA.Sprint1.Task3.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы сотавного присваивани                                   *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("* Формула объёма параллелепипеда                                          *");
        Console.WriteLine("***************************************************************************");
        double x, y, z;
        Console.WriteLine("Введите высоту параллелепипеда ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите ширину параллелепипеда ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоут параллелепипеда ");
        z = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Объём параллелепипеда = " + ds.ParallelepipedVolume(x, y, z));
        Console.ReadLine();
    }
}