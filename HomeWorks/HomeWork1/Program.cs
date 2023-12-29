Console.WriteLine("Домашняя работа №1");
Console.WriteLine("");
Console.WriteLine("----------------------");
Console.WriteLine("Задание 1. Рассчитать и вывести на экран площадь и периметр прямоугольника,");
Console.WriteLine("стороны которого запросить у пользователя (ввод с клавиатуры)");

double rectWidth = 0;
double rectHeight = 0;

Console.WriteLine("");
Console.WriteLine("Введите ширину прямоугольника:");
rectWidth = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите высоту прямоугольника:");
rectHeight = Convert.ToDouble(Console.ReadLine());

double rectSquare = rectHeight * rectWidth;
double rectPerimeter = 2 * rectWidth + 2 * rectHeight;
Console.WriteLine($"Площадь прямоугольная S={rectSquare}, периметр прямоугольника L={rectPerimeter}");
Console.WriteLine("");
Console.WriteLine("----------------------");
Console.WriteLine("Задание 2. Найдите сумму 1 + 2 + 3 + ... + n, где n вводится пользователем с клавиатуры");

int userNumber = 0;
int sum = 0;
Console.WriteLine("");
Console.WriteLine("Введите число n:");
userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
    sum += i;
}

Console.WriteLine($"Сумма чисел равна {sum}");
Console.WriteLine("");
Console.WriteLine("----------------------");
Console.WriteLine("Задание 3. Числа от 35 до 87, которые при делении на 7, в остатке дают 1, 2, 5");
Console.WriteLine("");
int a = 0;
for (int i = 35; i <= 87; i++)
{
    a = i % 7;
    if (a == 1 || a == 2 || a == 5)
    {
        Console.Write($"{i} ");
    }
}

Console.WriteLine("");
Console.WriteLine("----------------------");

Console.WriteLine("Задание 4. ");
int amountTotal = 45;
Console.WriteLine($"На складе {GetCorrectSuffixOfAvailable(amountTotal)} {amountTotal} {GetCorrectSuffixOfBoxCount(amountTotal)}. Сколько ящиков нужно отгрузить?");
int numbersInCar;


while (amountTotal > 0)
{
    numbersInCar = Convert.ToInt32(Console.ReadLine());

    if ((amountTotal - numbersInCar) > 0)
    {
        amountTotal -= numbersInCar;
        Console.WriteLine($"На складе {GetCorrectSuffixOfAvailable(amountTotal)} {amountTotal} {GetCorrectSuffixOfBoxCount(amountTotal)}. Сколько ящиков нужно отгрузить?");
    }

    else if ((amountTotal - numbersInCar) == 0)

    {
        amountTotal -= numbersInCar;
        Console.WriteLine($"{GetCorrectSuffixOfShipped(amountTotal)} {numbersInCar} {GetCorrectSuffixOfBoxCount(amountTotal)}. На складе не осталось яблок!");
    }

    else if ((amountTotal - numbersInCar) < 0)

    {
        Console.WriteLine($"{GetCorrectSuffixOfShipped(amountTotal)} только {amountTotal} {GetCorrectSuffixOfBoxCount(amountTotal)}. На складе не осталось яблок!");
        amountTotal = 0;
    }
}

return;


/*
 * Локальная функция для корректного окончания доступных ящиков в зависимости от количества
 */
static string GetCorrectSuffixOfAvailable(int count)
{
    if (count == 1)
    {
        return "доступен";
    }

    else if (count >= 2 & count <= 4)
    {
        return "доступны";
    }

    else if (count >= 5 & count <= 20)
    {
        return "доступны";
    }

    else if (count > 20 & count % 10 == 1)
    {
        return "доступен";
    }

    else if (count > 20 & count % 10 >= 2 & count % 10 <= 4)
    {
        return "доступны";
    }

    else if (count > 20 & count % 10 >= 5 & count % 10 <= 9)
    {
        return "доступно";
    }

    else
    {
        return "доступно";
    }

}

/*
 * Локальная функция для корректного окончания отгружено в зависимости от количества ящиков
 */
static string GetCorrectSuffixOfShipped(int count)
{
    if (count == 1)
    {
        return "Отгружен";
    }

    else if (count >= 2 & count <= 4)
    {
        return "Отгружены";
    }

    else if (count >= 5 & count <= 20)
    {
        return "Отгружено";
    }

    else if (count > 20 & count % 10 == 1)
    {
        return "Отгружен";
    }

    else if (count > 20 & count % 10 >= 2 & count % 10 <= 4)
    {
        return "Отгружены";
    }

    else if (count > 20 & count % 10 >= 5 & count % 10 <= 9)
    {
        return "Отгружено";
    }

    else
    {
        return "Отгружено";
    }

}

/*
 * Локальная функция для корректного окончания в зависимости от количества ящиков
 */
static string GetCorrectSuffixOfBoxCount(int сount)
{
    if (сount == 1)
    {
        return "ящик";
    }

    else if (сount >= 2 & сount <= 4)
    {
        return "ящика";
    }

    else if (сount >= 5 & сount <= 20)
    {
        return "ящиков";
    }

    else if (сount > 20 & сount % 10 == 1)
    {
        return "ящик";
    }

    else if (сount > 20 & сount % 10 >= 2 & сount % 10 <= 4)
    {
        return "ящика";
    }

    else if (сount > 20 & сount % 10 >= 5 & сount % 10 <= 9)
    {
        return "ящиков";
    }

    else
    {
        return "ящиков";
    }

}
