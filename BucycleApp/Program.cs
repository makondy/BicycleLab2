using BicycleLab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucycleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Отримання кількості велосипедів від користувача
            Console.Write("Введіть кількість велосипедів: ");
            int numberOfBicycles = int.Parse(Console.ReadLine());

            // Створення масиву для зберігання інформації про велосипеди
            Bicycle[] bicycles = new Bicycle[numberOfBicycles];

            // Цикл для введення даних про кожен велосипед
            for (int i = 0; i < numberOfBicycles; i++)
            {
                Console.WriteLine("\nВведіть дані для велосипеда #{0}:", i + 1);

                bicycles[i] = new Bicycle();

                Console.Write("Марка: ");
                bicycles[i].Brand = Console.ReadLine();

                Console.Write("Модель: ");
                bicycles[i].Model = Console.ReadLine();

                Console.Write("Рік випуску: ");
                bicycles[i].Year = int.Parse(Console.ReadLine());

                Console.Write("Тип велосипеда (гірський, міський тощо): ");
                bicycles[i].Type = Console.ReadLine();

                Console.Write("Вага (кг): ");
                bicycles[i].Weight = double.Parse(Console.ReadLine());

                Console.Write("Матеріал рами: ");
                bicycles[i].FrameMaterial = Console.ReadLine();

                Console.Write("Кількість швидкостей: ");
                bicycles[i].GearCount = int.Parse(Console.ReadLine());

                Console.Write("Пробіг (км): ");
                bicycles[i].Mileage = double.Parse(Console.ReadLine());

                // Розрахунок середньої швидкості
                Console.Write("Введіть пройдену відстань (км): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Введіть час (у годинах): ");
                double time = double.Parse(Console.ReadLine());

                double averageSpeed = bicycles[i].GetAverageSpeed(distance, time);
                Console.WriteLine($"Середня швидкість: {averageSpeed} км/год");
            }

            // Виведення інформації про всі велосипеди
            Console.WriteLine("\nІнформація про всі велосипеди:");
            foreach (var bike in bicycles)
            {
                bike.DisplayInfo();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
