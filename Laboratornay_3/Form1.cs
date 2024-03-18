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
                string input1 = fraction1.Text;
                string input2 = fraction2.Text;

                string[] parts1 = input1.Split('/');
                string[] parts2 = input2.Split('/');

                int numerator1 = int.Parse(parts1[0]);
                int denominator1 = int.Parse(parts1[1]);

                int numerator2 = int.Parse(parts2[0]);
                int denominator2 = int.Parse(parts2[1]);

                var frac1 = new Fraction(numerator1, denominator1).Simplify(); ;
                var frac2 = new Fraction(numerator2, denominator2).Simplify(); ;
    
                Fraction result = null;
                switch (comboBox1.Text)
                {
                    case "+":
                        
                        break;
                    case "-":
                       
                        break;
                    case "*":
                        
                        break;
                    case "/":
                        
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
           
    }
    
}
