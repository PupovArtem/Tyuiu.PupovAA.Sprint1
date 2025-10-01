using Tyuiu.PupovAA.Sprint1.Task6.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Пупов А. А. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Conver                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Пупов Артём Андреевич | ИБКСб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу: пользователь вводит текст. Напечатать те слова,     *");
        Console.WriteLine("*  которые являются симметричными (например: казак, шалаш).               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите слово");
        String str = Console.ReadLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write(ds.CheckSymmetricalWords(str));
        Console.Write("-это симметричное слово");
        Console.ReadLine();




    }
}