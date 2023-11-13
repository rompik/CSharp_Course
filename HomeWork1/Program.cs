//using System.Runtime.Intrinsics.Arm;

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
    sum = sum + i;
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
Console.WriteLine($"На складе доступно {amountTotal} ящиков. Сколько ящиков нужно отгрузить?");
int numbersInCar = 0;


/*
 * Добавить метод для определения корректного суффикса для количества ящиков
 * string boxCorrectCounterSuffix = "ящик";
 */
while (amountTotal > 0)
{
    numbersInCar = Convert.ToInt32(Console.ReadLine());

    if ((amountTotal - numbersInCar) > 0)
    {
        amountTotal = amountTotal - numbersInCar;
        Console.WriteLine($"На складе доступно {amountTotal} {GetCorrectSuffixOfBoxCount(amountTotal)}. Сколько ящиков нужно отгрузить?");
    }

    else if ((amountTotal - numbersInCar) == 0)

    {
        amountTotal = amountTotal - numbersInCar;
        Console.WriteLine($"Отгружено {numbersInCar} {GetCorrectSuffixOfBoxCount(amountTotal)}. На складе не осталось яблок!");
    }

    else if ((amountTotal - numbersInCar) < 0)

    {
        Console.WriteLine($"Отгружено только {amountTotal} {GetCorrectSuffixOfBoxCount(amountTotal)}. На складе не осталось яблок!");
        amountTotal = 0;
    }
}

string GetCorrectSuffixOfBoxCount(int Count)
{
    if (Count == 1 || Count % 10 == 1)
    {
        return "ящик";
    }

    else if ((Count >= 2 & Count <= 4))
    {
        return "ящика";
    }

    else if (Count % 10 >= 2 & Count % 10 <= 4)
    {
        return "ящика";
    }

    else if (Count >= 5 & Count <= 20)
    {
        return "ящиков";
    }

    else if (Count % 10 >= 5 & Count % 10 <= 9)
    {
        return "ящиков";
    }

    return "ящиков";
}
