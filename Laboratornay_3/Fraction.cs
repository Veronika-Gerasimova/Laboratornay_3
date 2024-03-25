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
            return b == 0 ? a : GCD(b, a % b);// Если (b == 0), то возвращается значение a. Если b не равно нулю, то вызывается рекурсивно метод GCD с аргументами b и a % b
        }

        //Реализация умножения
        public Fraction Multiply(Fraction other)
        {
            int num = numerator * other.numerator;
            int den = denominator * other.denominator;
            return new Fraction(num, den);
        }

        //Реализация деления
        public Fraction Divide(Fraction other)
        {
            if (other.numerator == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            int num = numerator * other.denominator;
            int den = denominator * other.numerator;
            return new Fraction(num, den);
        }

        //Сравнение дробей
        public int CompareTo(Fraction other)
        {
            int num1 = numerator * other.denominator;
            int num2 = other.numerator * denominator;
            return num1.CompareTo(num2);
        }
        
        //Метод позволяет сравнить два объекта
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Fraction other = (Fraction)obj;
            return this.numerator == other.numerator && this.denominator == other.denominator;
        }
        //Возвращает число-дробь, по которому сравниваются объекты
        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }

        public static bool operator ==(Fraction frac1, Fraction frac2)
        {
            if (ReferenceEquals(frac1, frac2))
            {
                return true;
            }

            if (frac1 is null || frac2 is null)
            {
                return false;
            }

            return frac1.Equals(frac2);
        }

        public static bool operator !=(Fraction frac1, Fraction frac2)
        {
            return !(frac1 == frac2);
        }

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            int num = frac1.numerator * frac2.denominator + frac2.numerator * frac1.denominator;
            int den = frac1.denominator * frac2.denominator;
            return new Fraction(num, den).Simplify();
        }

        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            int num = frac1.numerator * frac2.denominator - frac2.numerator * frac1.denominator;
            int den = frac1.denominator * frac2.denominator;
            return new Fraction(num, den).Simplify();
        }

        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            int num = frac1.numerator * frac2.numerator;
            int den = frac1.denominator * frac2.denominator;
            return new Fraction(num, den).Simplify();
        }

        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            if (frac2.numerator == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            int num = frac1.numerator * frac2.denominator;
            int den = frac1.denominator * frac2.numerator;
            return new Fraction(num, den).Simplify();
        }

    }
}
