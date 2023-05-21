using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Простой консольный калькулятор");

        Console.Write("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите операцию (+, -, *, /): ");
        char operation = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                result = number1 / number2;
                break;
            default:
                Console.WriteLine("Неверная операция");
                break;
        }

        Console.WriteLine("Результат: " + result);

        // Коммит изменений в локальный репозиторий
        // git commit -am "Добавлен простой калькулятор"

        // Запушить изменения в удалённый репозиторий
        // git push origin master
    }
}