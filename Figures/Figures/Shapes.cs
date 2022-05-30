using System;

namespace Figures
{
    /*
     Задание:

    Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

    Юнит-тесты

    Легкость добавления других фигур

    Вычисление площади фигуры без знания типа фигуры

    Проверку на то, является ли треугольник прямоугольным
*/
    
    public abstract class Shape
    {
        public abstract float getArea();
    }

    public class Circle : Shape
    {
        private float radius;

        public Circle(float radius)
        {
            if (radius > 0.0f)
            {
                this.radius = radius;
            }
            else
            {
                throw new Exception("Такой круг невозможен");
            }
        }


        public override float getArea()
        {
            return (float)Math.PI * (radius * radius);
        }
    }

    public class Triangle : Shape
    {
        private float sideA;
        private float sideB;
        private float sideC;

        public Triangle(float sideA, float sideB, float sideC)
        {
            if(sideA > 0.0f & sideB > 0.0f & sideC > 0.0f &
            !(sideA + sideB <= sideC) & !(sideC + sideB <= sideA) & !(sideA + sideC <= sideB))
            {
                this.sideA = sideA;
                this.sideB = sideB;
                this.sideC = sideC;
            }
            else
            {
                throw new Exception("Такой треугольник невозможен");
            }
        }

        public override float getArea()
        {
            float p = (sideA + sideB + sideC) / 2.0f;
            return (float)Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool IsRight()
        {
            return Math.Abs(sideA * sideA - ((sideB * sideB) + (sideC * sideC))) < 0.005 ||
                   Math.Abs(sideB * sideB - ((sideA * sideA) + (sideC * sideC))) < 0.005 ||
                   Math.Abs(sideC * sideC - ((sideB * sideB) + (sideA * sideA))) < 0.005;

        }
         
        
    }
    
}