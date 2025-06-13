using System;
using System.Windows.Forms;

namespace Ejercicio_16
{
    public partial class Form1 : Form
    {
        private double valorAnterior = 0;
        private string operacion = "";
        private bool inicioNuevoNumero = true;

        public Form1()
        {
            InitializeComponent();




        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (inicioNuevoNumero || txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
                inicioNuevoNumero = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            valorAnterior = double.Parse(txtDisplay.Text);
            operacion = btn.Text;
            inicioNuevoNumero = true;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
                inicioNuevoNumero = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            valorAnterior = 0;
            operacion = "";
            inicioNuevoNumero = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double valorActual = double.Parse(txtDisplay.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = valorAnterior + valorActual;
                    break;
                case "-":
                    resultado = valorAnterior - valorActual;
                    break;
                case "×":
                case "*":
                    resultado = valorAnterior * valorActual;
                    break;
                case "÷":
                case "/":
                    if (valorActual != 0)
                        resultado = valorAnterior / valorActual;
                    else
                    {
                        MessageBox.Show("Error: División por cero.");
                        return;
                    }
                    break;
            }

            txtDisplay.Text = resultado.ToString();
            inicioNuevoNumero = true;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



