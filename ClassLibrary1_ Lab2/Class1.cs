using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClassLibrary1_Lab2
{
    /// <summary>
    /// Лабораторная работа №2 вариант 17
    /// </summary>
    public class TaskSolver
    {
        private readonly Random _random;

        public TaskSolver()
        {
            _random = new Random();
        }
        //Задача 1: Проверка попадания точки в круг

        /// <summary>
        /// Проверяет положение точки относительно круга
        /// </summary>
        public string CheckPointPosition(double pointX, double pointY,
                                         double circleCenterX, double circleCenterY,
                                         double radius, out Color resultColor)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным числом", nameof(radius));
            }

            double distance = Math.Sqrt(Math.Pow(pointX - circleCenterX, 2) +
                                       Math.Pow(pointY - circleCenterY, 2));

            const double epsilon = 1e-9;
            string result;

            if (Math.Abs(distance - radius) < epsilon)
            {
                result = "Точка лежит НА окружности";
                resultColor = Color.Orange;
            }
            else if (distance < radius)
            {
                result = "Точка находится ВНУТРИ круга";
                resultColor = Color.Green;
            }
            else
            {
                result = "Точка находится СНАРУЖИ круга";
                resultColor = Color.Red;
            }

            return result;
        }
    }
}