using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornay_3
{
    public class Fraction
    {
        public int numerator;
        public int denominator;

        public Fraction(int num, int den)
        {
            if (den == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0");
            this.numerator = num;
            this.denominator = den;
        }
        //Метод, возвращающий строковое представление дроби в формате числитель/знаменатель
        public string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        //Реализация сложения дробей
        public Fraction Add(Fraction other)
        {
            int num = numerator * other.denominator + other.numerator * denominator;
            int den = denominator * other.denominator;
            return new Fraction(num, den).Simplify();
        }

        //Реализация вычитания
        public Fraction Subtract(Fraction other)
        {
            int num = numerator * other.denominator - other.numerator * denominator;
            int den = denominator * other.denominator;
            return new Fraction(num, den).Simplify();
        }

        //Сокращение дроби
        public Fraction Simplify()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator)); //вычисление НОД для двух чисел
            int sign = Math.Sign(numerator) * Math.Sign(denominator); //определение знака результирующей дроби
            return new Fraction(sign * numerator / gcd, denominator / gcd);
        }

        //Вычисление наибольшего общего делителя с помощью алгоритма Евклида
        private int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
