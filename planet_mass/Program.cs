using System;

class Program
{
    static void Main()
    {
        // Маси планет у кілограмах
        double[] planetMasses = {
            1.989e30, // Сонце
            3.3011e23, // Меркурій
            4.8675e24, // Венера
            5.972e24, // Земля
            6.4171e23, // Марс
            1.8982e27, // Юпітер
            5.6834e26, // Сатурн
            8.6810e25, // Уран
            1.02413e26 // Нептун
        };

        // Обчислюємо загальну масу планет
        double totalMass = 0;
        foreach (double mass in planetMasses)
        {
            totalMass += mass;
        }

        // Виводимо загальну масу планет
        Console.WriteLine("Загальна маса планет нашої сонячної системи: " + totalMass.ToString("e") + " кг");
    }
}