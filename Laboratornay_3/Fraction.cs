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


    }
}
