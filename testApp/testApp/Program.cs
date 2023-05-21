using System;

class Calculator
{
    static void Main()
    {
        bool flag = true;
        char choice;
        Console.WriteLine("Всем привет это простой калькулятор который нужен для 5 лаабораторной работы, а это его приветственное сообщение!");
        Console.WriteLine("Вы хотите начать расчёты на этом калькуляторе? [y/n]");
        choice = Convert.ToChar(Console.ReadLine());
        
        if(choice == 'y')
            while (flag) {
                {
                    Console.WriteLine("Простой консольный калькулятор");
                    Console.Write("Введите первое число: ");
                    double number1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите второе число: ");
                    double number2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите операцию (+, -, *, /, ^): ");
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
                        case '^':
                            result = Math.Pow(number1, number2);
                            break;
                        default:
                            Console.WriteLine("Неверная операция");
                            break;
                    }
                    Console.WriteLine("Результат: " + result);
                    Console.WriteLine("Вы хотите продолжить?[y/n]");
                    choice = Convert.ToChar(Console.ReadLine());
                    if (choice != 'y')
                        flag = false;
                }
        }
            Console.WriteLine("Всем пока, увидимся позже!");
        // Коммит изменений в локальный репозиторий
        // git commit -am "Добавлен простой калькулятор"

        // Запушить изменения в удалённый репозиторий
        // git push origin master
    }
}