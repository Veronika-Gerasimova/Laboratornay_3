namespace Laboratornay_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //инициализирует все компоненты формы
            this.Text = "Калькулятор дробей";
            this.ActiveControl = fraction1;
        }

        private void fraction1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                fraction2.Focus();
            }
        }

        private void fraction1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void fraction2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                string input1 = fraction1.Text;
                string input2 = fraction2.Text;

                string[] parts1 = input1.Split('/');
                string[] parts2 = input2.Split('/');

                if (parts1.Length != 2 || parts2.Length != 2)
                {
                    throw new FormatException("Дроби должны быть в формате 'числитель/знаменатель'");
                }

                int numerator1 = int.Parse(parts1[0]);
                int denominator1 = int.Parse(parts1[1]);

                int numerator2 = int.Parse(parts2[0]);
                int denominator2 = int.Parse(parts2[1]);

                //Если пользователь ввел неправильную дробь или знаменатель равен 0
                if (numerator1 > denominator1 || denominator1 == 0 || numerator2 > denominator2 || denominator2 == 0)
                {
                    throw new ArgumentException("Некорректные значения числителя и знаменателя");
                }

                if (numerator1 == denominator1 && numerator2 == denominator2)
                {
                    throw new ArgumentException("Числитель и знаменатель не могут быть равны в данном случае. Введите правильную дробь");
                }

                var frac1 = new Fraction(numerator1, denominator1).Simplify(); ;
                var frac2 = new Fraction(numerator2, denominator2).Simplify(); ;

                // Сравнение дробей
                int comparisonResult = frac1.CompareTo(frac2);

                // Вывод результата сравнения
                if (comparisonResult < 0)
                {
                    resultTwo.Text = "Первая дробь меньше второй";
                }
                else if (comparisonResult > 0)
                {
                    resultTwo.Text = "Первая дробь больше второй";
                }
                else
                {
                    resultTwo.Text = "Дроби равны";
                }

                bool areEqual = frac1.Equals(frac2);

                // Вывод результата сравнения для Equals
                if (areEqual)
                {
                    resultThree.Text = "Дроби равны";
                }
                else
                {
                    resultThree.Text = "Дроби не равны";
                }


                Fraction result = null;
                switch (comboBox1.Text)
                {
                    case "+":
                        result = frac1.Add(frac2);
                        break;
                    case "-":
                        result = frac1.Subtract(frac2);
                        break;
                    case "*":
                        result = frac1.Multiply(frac2);
                        break;
                    case "/":
                        result = frac1.Divide(frac2);
                        break;
                    default:
                        break;
                }

                if (result != null)
                {
                    resultLabel.Text = result.ToString();
                    result.Simplify();
                }
            }
            catch (FormatException)
            {
                // Обработка некорректного формата
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
    }
    
}
