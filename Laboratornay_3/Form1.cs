namespace Laboratornay_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //�������������� ��� ���������� �����
            this.Text = "����������� ������";
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
                    throw new FormatException("����� ������ ���� � ������� '���������/�����������'");
                }

                int numerator1 = int.Parse(parts1[0]);
                int denominator1 = int.Parse(parts1[1]);

                int numerator2 = int.Parse(parts2[0]);
                int denominator2 = int.Parse(parts2[1]);

                //���� ������������ ���� ������������ ����� ��� ����������� ����� 0
                if (numerator1 > denominator1 || denominator1 == 0 || numerator2 > denominator2 || denominator2 == 0)
                {
                    throw new ArgumentException("������������ �������� ��������� � �����������");
                }

                if (numerator1 == denominator1 && numerator2 == denominator2)
                {
                    throw new ArgumentException("��������� � ����������� �� ����� ���� ����� � ������ ������. ������� ���������� �����");
                }

                var frac1 = new Fraction(numerator1, denominator1).Simplify(); ;
                var frac2 = new Fraction(numerator2, denominator2).Simplify(); ;

                // ��������� ������
                int comparisonResult = frac1.CompareTo(frac2);

                // ����� ���������� ���������
                if (comparisonResult < 0)
                {
                    resultTwo.Text = "������ ����� ������ ������";
                }
                else if (comparisonResult > 0)
                {
                    resultTwo.Text = "������ ����� ������ ������";
                }
                else
                {
                    resultTwo.Text = "����� �����";
                }

                bool areEqual = frac1.Equals(frac2);

                // ����� ���������� ��������� ��� Equals
                if (areEqual)
                {
                    resultThree.Text = "����� �����";
                }
                else
                {
                    resultThree.Text = "����� �� �����";
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
                // ��������� ������������� �������
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
           
    }
    
}
