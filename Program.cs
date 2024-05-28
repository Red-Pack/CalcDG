using System;

namespace CalculatorApp
{
    /// <summary>
    /// Класс для выполнения арифметических операций.
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Метод для сложения двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат сложения двух чисел.</returns>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Метод для вычитания одного числа из другого.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат вычитания второго числа из первого.</returns>
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Метод для умножения двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат умножения двух чисел.</returns>
        public double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Метод для деления одного числа на другое.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат деления первого числа на второе.</returns>
        /// <exception cref="DivideByZeroException">Выбрасывается, если второе число равно нулю.</exception>
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно.");
            }
            return a / b;
        }
    }

    /// <summary>
    /// Главный класс программы, содержащий точку входа.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double num1 = 10;
            double num2 = 5;

            // Выполнение арифметических операций и вывод результатов
            Console.WriteLine($"Сложение: {num1} + {num2} = {calculator.Add(num1, num2)}");
            Console.WriteLine($"Вычитание: {num1} - {num2} = {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Умножение: {num1} * {num2} = {calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Деление: {num1} / {num2} = {calculator.Divide(num1, num2)}");

            Console.WriteLine("Нажмите любую клавишу для завершения.");
            Console.ReadKey();
        }
    }
}