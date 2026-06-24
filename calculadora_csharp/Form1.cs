using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices;

namespace calculadora_csharp
{
    public partial class Form1 : Form
    {

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btn_igual_Click(btn_igual, EventArgs.Empty);

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        string operacao = "";
        double valor1 = 0;
        double ultimo_valor = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btn_9_Click(btn_9, EventArgs.Empty);

            }
            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btn_8_Click(btn_8, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btn_7_Click(btn_7, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btn_6_Click(btn_6, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btn_5_Click(btn_5, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btn_4_Click(btn_4, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btn_3_Click(btn_3, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btn_2_Click_1(btn_2, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                button1_Click(btn_1, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btn_0_Click(btn_0, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.X)
            {
                btn_multi_Click(btn_multi, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                btn_sub_Click(btn_sub, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Oemplus)
            {
                btn_adc_Click(btn_adc, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.OemQuestion)
            {
                btn_dividir_Click(btn_dividir, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                btn_igual_Click(btn_igual, EventArgs.Empty);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (numero.Text == "0")
                {
                    numero.Text = "1";
                }
                else
                {
                    numero.Text = numero.Text + "1";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "0";
            }
            else
            {
                numero.Text = numero.Text + "0";
            }
        }




        private void btn_2_Click_1(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "2";
            }
            else
            {
                numero.Text = numero.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "3";
            }
            else
            {
                numero.Text = numero.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "4";
            }
            else
            {
                numero.Text = numero.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "5";
            }
            else
            {
                numero.Text = numero.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "6";
            }
            else
            {
                numero.Text = numero.Text + "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "7";
            }
            else
            {
                numero.Text = numero.Text + "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "8";
            }
            else
            {
                numero.Text = numero.Text + "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (numero.Text == "0")
            {
                numero.Text = "9";
            }
            else
            {
                numero.Text = numero.Text + "9";
            }
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numero.Text);
            operacao = "/";
            numero.Text = "0";
            numero_2.Text = $"{valor1} {operacao}";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numero.Text);
            operacao = "*";
            numero.Text = "0";
            numero_2.Text = $"{valor1} {operacao}";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numero.Text);
            operacao = "-";
            numero.Text = "0";
            numero_2.Text = $"{valor1} {operacao}";
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_adc_Click(object sender, EventArgs e)
        {
            valor1 = double.Parse(numero.Text);
            operacao = "+";
            numero.Text = "0";  
            numero_2.Text = $"{valor1} {operacao}";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            double valor2;
            if (!numero_2.Text.EndsWith("="))
            {
                valor2 = double.Parse(numero.Text);
                ultimo_valor = valor2;
            }
            else
            {
                valor2 = ultimo_valor;
            }
                
            double resultado = 0;
            if (operacao == "/")
            {
                resultado = valor1 / valor2;

            }
            else if (operacao == "*")
            {
                resultado = valor1 * valor2;

            }
            else if (operacao == "-")
            {
                resultado = valor1 - valor2;

            }
            else if (operacao == "+")
            {
                resultado = valor1 + valor2;

            }

            
            numero.Text = resultado.ToString();
            numero_2.Text = $"{valor1} {operacao} {valor2} =";
            valor1 = resultado;






        }

        private void btn_virgula_Click(object sender, EventArgs e)
        {
            if (numero.Text.Contains(","))
            {
                numero.Text = numero.Text;
            }
            else
            {
                numero.Text = numero.Text + ",";
            }

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            numero.Text = "0";
            numero_2.Text = null;
            
        }
    }
}
