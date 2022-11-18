void Select()
{
    Console.WriteLine("Введите начальную дату");
    string first = Console.ReadLine();
    DateTime dateFirst = Date(first);

    if (Date(first) == DateTime.MinValue)
    {
        Console.WriteLine();
        Console.WriteLine("Введите корректное значение");
        Console.WriteLine();
        Select();
    }

    else
    {
        Console.WriteLine("Введите конечную дату");
        string second = Console.ReadLine();
        DateTime dateSecond = Date(second);
        if (dateFirst == dateSecond)
        {
            Console.WriteLine();
            Console.WriteLine("Даты совпадают");
            Console.WriteLine();
            return;
        }

        else if (dateFirst > dateSecond)
        {
            Console.WriteLine();
            Console.WriteLine("Начальная дата больше чем конечная");
            Console.WriteLine();
            return;
        }

        else
        {
            TimeSpan days = dateSecond.Subtract(dateFirst);
            Console.WriteLine($"Количество дней между датами - {days.Days}");
        }
    }
}
DateTime Date(string date)
{
    try
    {
        string[] words = date.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        bool parse = int.TryParse(words[0], out var firstDate);
        bool parse2 = int.TryParse(words[1], out var firstDate2);
        bool parse3 = int.TryParse(words[2], out var firstDate3);

        if (parse && parse2 && parse3)
        {
            DateTime dateFirst = new DateTime(firstDate, firstDate2, firstDate3);
            return dateFirst;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Введите корректное значение");
            Console.WriteLine();
            Environment.Exit(0);
            return DateTime.MinValue;
        }
    }
    catch
    {
        return DateTime.MinValue;
    }
}
while (true)
{
    Select();
}
